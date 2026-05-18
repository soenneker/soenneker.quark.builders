using System;
using System.Collections.Generic;
using Soenneker.Extensions.String;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents a CSS value that can be either a CSS class or inline style, generated from a builder.
/// </summary>
/// <typeparam name="TBuilder">The type of CSS builder used to generate the value.</typeparam>
public readonly struct CssValue<TBuilder> : IEquatable<CssValue<TBuilder>> where TBuilder : class, ICssBuilder
{
    private readonly string _value;
    private readonly string? _styleValue;
    private readonly string? _cssSelector;
    private readonly bool _selectorIsAbsolute;

    // Cache generic-type checks per closed generic
    private static readonly bool _isHeight = typeof(TBuilder) == typeof(HeightBuilder);
    private static readonly bool _isWidth = typeof(TBuilder) == typeof(WidthBuilder);

    private CssValue(string value, string? styleValue = null, string? cssSelector = null, bool selectorIsAbsolute = false)
    {
        _value = value ?? string.Empty;
        _styleValue = styleValue;
        _cssSelector = cssSelector;
        _selectorIsAbsolute = selectorIsAbsolute;
    }

    private CssValue(CssValue<TBuilder> source, string selector, bool selectorIsAbsolute)
    {
        _value = source._value;
        _styleValue = source._styleValue;
        _cssSelector = selector;
        _selectorIsAbsolute = selectorIsAbsolute;
    }

    /// <summary>
    /// Creates a single CssValue from multiple CSS contributors while keeping the target slot typed to <typeparamref name="TBuilder"/>.
    /// This supports scenarios such as combining a base utility and a variant-decorated utility in one component property.
    /// </summary>
    public static CssValue<TBuilder> For(params object?[] values) => Combine(values);

    /// <summary>
    /// Implicitly converts a CSS builder to a CssValue.
    /// </summary>
    public static implicit operator CssValue<TBuilder>(TBuilder builder) => new(builder.ToClass(), builder.ToStyle());

    /// <summary>
    /// Implicitly converts a variant-wrapped builder to a CssValue for typed component slots.
    /// </summary>
    public static implicit operator CssValue<TBuilder>(VariantBuilder builder) => new(builder.ToClass(), builder.ToStyle());

    /// <summary>
    /// Implicitly converts a string to a CssValue.
    /// </summary>
    public static implicit operator CssValue<TBuilder>(string value) => new(value);

    /// <summary>
    /// Implicitly converts an integer to a CssValue. For HeightBuilder and WidthBuilder, converts to pixel values.
    /// </summary>
    public static implicit operator CssValue<TBuilder>(int value)
    {
        if (!_isHeight && !_isWidth)
            return new CssValue<TBuilder>(value.ToString());

        string pixelValue = $"{value}px";
        return new CssValue<TBuilder>(pixelValue, pixelValue);
    }

    /// <summary>
    /// Implicitly converts a CssValue to a string.
    /// </summary>
    public static implicit operator string(CssValue<TBuilder> v) => v._value;

    /// <summary>
    /// Returns the string representation of this CSS value.
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Gets whether this CSS value is empty.
    /// </summary>
    public bool IsEmpty => _value.IsNullOrEmpty();

    /// <summary>
    /// Gets whether this CSS value represents an inline style.
    /// </summary>
    public bool IsCssStyle => !string.IsNullOrEmpty(_styleValue);

    /// <summary>
    /// Gets whether this CSS value represents a CSS class (e.g., "bg-primary") rather than an inline style.
    /// </summary>
    public bool IsCssClass => !IsCssStyle && !IsEmpty;

    public string? CssSelector => _cssSelector;

    public bool SelectorIsAbsolute => _selectorIsAbsolute;

    /// <summary>Gets the explicit style representation if available.</summary>
    public string StyleValue
    {
        get
        {
            return _styleValue ?? string.Empty;
        }
    }

    /// <summary>
    /// Creates a new CssValue with the specified CSS selector.
    /// </summary>
    /// <param name="selector">The CSS selector to apply.</param>
    /// <param name="absolute">Whether the selector is absolute (not relative to base selector).</param>
    /// <returns>A new CssValue with the specified selector.</returns>
    public CssValue<TBuilder> WithSelector(string selector, bool absolute = false)
    {
        if (selector.IsNullOrWhiteSpace())
            return this;

        ReadOnlySpan<char> trimmed = selector.AsSpan().Trim();
        if (trimmed.Length != selector.Length)
            return new CssValue<TBuilder>(this, trimmed.ToString(), absolute);

        return new CssValue<TBuilder>(this, selector, absolute);
    }

    /// <summary>
    /// Returns a new CssValue with additional CSS contributors appended.
    /// </summary>
    public CssValue<TBuilder> Add(params object?[] values)
    {
        if (values is not { Length: > 0 })
            return this;

        return Combine(this, values);
    }

    /// <summary>
    /// Gets whether this non-empty value affects the generated markup (class or style).
    /// </summary>
    public bool AffectsMarkup => !IsEmpty;

    /// <summary>
    /// Determines whether this CssValue is equal to another CssValue.
    /// </summary>
    public bool Equals(CssValue<TBuilder> other) => _value == other._value;

    /// <summary>
    /// Determines whether this CssValue is equal to the specified object.
    /// </summary>
    public override bool Equals(object? obj) => obj is CssValue<TBuilder> o && Equals(o);

    /// <summary>
    /// Returns the hash code for this CssValue.
    /// </summary>
    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(_value);

    /// <summary>
    /// Determines whether two CssValue instances are equal.
    /// </summary>
    public static bool operator ==(CssValue<TBuilder> a, CssValue<TBuilder> b) => a.Equals(b);

    /// <summary>
    /// Determines whether two CssValue instances are not equal.
    /// </summary>
    public static bool operator !=(CssValue<TBuilder> a, CssValue<TBuilder> b) => !a.Equals(b);

    private static CssValue<TBuilder> Combine(IReadOnlyList<object?> values) => Combine(null, values);

    private static CssValue<TBuilder> Combine(object? first, IReadOnlyList<object?> values)
    {
        var combinedValue = new PooledStringBuilder();
        var combinedStyle = new PooledStringBuilder();
        var hasValue = false;
        var hasStyle = false;
        string? combinedSelector = null;
        var combinedSelectorIsAbsolute = false;

        try
        {
            AppendValue(first, ref combinedValue, ref combinedStyle, ref hasValue, ref hasStyle, ref combinedSelector, ref combinedSelectorIsAbsolute);

            for (var i = 0; i < values.Count; i++)
            {
                object? value = values[i];
                AppendValue(value, ref combinedValue, ref combinedStyle, ref hasValue, ref hasStyle, ref combinedSelector, ref combinedSelectorIsAbsolute);
            }

            return new CssValue<TBuilder>(
                hasValue ? combinedValue.ToString() : string.Empty,
                hasStyle ? combinedStyle.ToString() : null,
                combinedSelector,
                combinedSelectorIsAbsolute);
        }
        finally
        {
            combinedValue.Dispose();
            combinedStyle.Dispose();
        }
    }

    private static void AppendValue(
        object? value,
        ref PooledStringBuilder combinedValue,
        ref PooledStringBuilder combinedStyle,
        ref bool hasValue,
        ref bool hasStyle,
        ref string? combinedSelector,
        ref bool combinedSelectorIsAbsolute)
    {
        switch (value)
        {
            case null:
                return;
            case CssValue<TBuilder> cssValue:
                AppendSegment(ref combinedValue, ref hasValue, cssValue._value, ' ');
                AppendStyle(ref combinedStyle, ref hasStyle, cssValue._styleValue);
                MergeSelector(ref combinedSelector, ref combinedSelectorIsAbsolute, cssValue._cssSelector, cssValue._selectorIsAbsolute);
                return;
            case ICssBuilder builder:
                AppendSegment(ref combinedValue, ref hasValue, builder.ToClass(), ' ');
                AppendStyle(ref combinedStyle, ref hasStyle, builder.ToStyle());
                return;
            case string str:
                AppendSegment(ref combinedValue, ref hasValue, str, ' ');
                return;
            case int intValue:
                CssValue<TBuilder> numeric = intValue;
                AppendSegment(ref combinedValue, ref hasValue, numeric._value, ' ');
                AppendStyle(ref combinedStyle, ref hasStyle, numeric._styleValue);
                return;
            default:
                AppendSegment(ref combinedValue, ref hasValue, value.ToString(), ' ');
                return;
        }
    }

    private static void MergeSelector(ref string? currentSelector, ref bool currentAbsolute, string? nextSelector, bool nextAbsolute)
    {
        if (nextSelector.IsNullOrWhiteSpace())
            return;

        if (currentSelector.IsNullOrWhiteSpace())
        {
            currentSelector = nextSelector;
            currentAbsolute = nextAbsolute;
            return;
        }

        if (!string.Equals(currentSelector, nextSelector, StringComparison.Ordinal) || currentAbsolute != nextAbsolute)
            throw new InvalidOperationException("Cannot combine CssValue instances with different CSS selectors.");
    }

    private static void AppendStyle(ref PooledStringBuilder current, ref bool hasValue, string? next)
    {
        if (next.IsNullOrWhiteSpace())
            return;

        ReadOnlySpan<char> trimmed = next.AsSpan().Trim().TrimEnd(';');

        if (trimmed.Length == 0)
            return;

        if (hasValue)
            current.Append("; ");
        else
            hasValue = true;

        AppendSpan(ref current, trimmed);
    }

    private static void AppendSegment(ref PooledStringBuilder current, ref bool hasValue, string? next, char separator)
    {
        if (next.IsNullOrWhiteSpace())
            return;

        ReadOnlySpan<char> trimmed = next.AsSpan().Trim();

        if (trimmed.Length == 0)
            return;

        if (hasValue)
            current.Append(separator);
        else
            hasValue = true;

        AppendSpan(ref current, trimmed);
    }

    private static void AppendSpan(ref PooledStringBuilder builder, ReadOnlySpan<char> value)
    {
        for (var i = 0; i < value.Length; i++)
            builder.Append(value[i]);
    }
}
