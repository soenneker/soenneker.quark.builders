using System;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Represents utility classes generated from a builder.
/// </summary>
/// <typeparam name="TBuilder">The type of CSS builder used to generate the value.</typeparam>
public readonly struct CssValue<TBuilder> : IEquatable<CssValue<TBuilder>> where TBuilder : class, ICssBuilder
{
    private readonly string? _value;

    private CssValue(string value) => _value = value;

    /// <summary>
    /// Creates a single CssValue from multiple CSS contributors while keeping the target slot typed to <typeparamref name="TBuilder"/>.
    /// This supports scenarios such as combining a base utility and a variant-decorated utility in one component property.
    /// </summary>
    /// <param name="values">CSS value contributors to combine, in order.</param>
    /// <returns>A CSS value containing the combined contributors.</returns>
    public static CssValue<TBuilder> For(params ReadOnlySpan<CssValue<TBuilder>> values) => Combine(values);

    /// <summary>Creates an empty typed CSS value.</summary>
    /// <returns>An empty CSS value.</returns>
    public static CssValue<TBuilder> For() => new(string.Empty);

    /// <summary>Creates a typed CSS value from one contributor without boxing or a parameter array.</summary>
    /// <param name="value">The CSS contributor to convert.</param>
    /// <returns>The supplied CSS value.</returns>
    public static CssValue<TBuilder> For(CssValue<TBuilder> value) => value;

    /// <summary>Combines two contributors without boxing or a parameter array.</summary>
    /// <param name="first">The first CSS contributor.</param>
    /// <param name="second">The second CSS contributor.</param>
    /// <returns>The combined CSS value.</returns>
    public static CssValue<TBuilder> For(CssValue<TBuilder> first, CssValue<TBuilder> second) => CombinePair(first, second);


    /// <summary>Snapshots the classes emitted by an explicitly supplied builder.</summary>
    /// <param name="builder">The builder whose output should be used.</param>
    /// <returns>The builder output without parsing or normalization.</returns>
    public static CssValue<TBuilder> FromBuilder(ICssBuilder builder) => new(builder.ToClass());

    /// <summary>Creates a typed value from complete classes without adding prefixes or interpreting tokens.</summary>
    /// <param name="classes">The exact classes to emit.</param>
    public static CssValue<TBuilder> Raw(string classes) => new(classes);

    /// <summary>
    /// Implicitly converts a CSS builder to a CssValue.
    /// </summary>
    /// <param name="builder">Builder to configure.</param>
    /// <returns>A CSS value containing the combined contributors.</returns>
    public static implicit operator CssValue<TBuilder>(TBuilder builder) => new(builder.ToClass());

    /// <summary>
    /// Implicitly converts a variant-wrapped builder to a CssValue for typed component slots.
    /// </summary>
    /// <param name="builder">Builder to configure.</param>
    /// <returns>A CSS value containing the combined contributors.</returns>
    public static implicit operator CssValue<TBuilder>(VariantBuilder builder) => new(builder.ToClass());

    /// <summary>
    /// Implicitly converts a string to a CssValue.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>A CSS value containing the combined contributors.</returns>
    public static implicit operator CssValue<TBuilder>(string value) => new(value);

    /// <summary>
    /// Converts the CSS Value to its string representation.
    /// </summary>
    /// <param name="v">CSS value to convert to text.</param>
    /// <returns>The text produced by operator string.</returns>
    public static implicit operator string(CssValue<TBuilder> v) => v._value ?? string.Empty;

    /// <summary>
    /// Returns the string representation of this CSS value.
    /// </summary>
    public override string ToString() => _value ?? string.Empty;

    /// <summary>
    /// Gets whether this CSS value is empty.
    /// </summary>
    public bool IsEmpty => string.IsNullOrEmpty(_value);

    /// <summary>
    /// Returns a new CssValue with additional CSS contributors appended.
    /// </summary>
    /// <param name="values">CSS value contributors to combine, in order.</param>
    /// <returns>A CSS value containing the combined contributors.</returns>
    public CssValue<TBuilder> Add(params ReadOnlySpan<CssValue<TBuilder>> values)
    {
        if (values.IsEmpty)
            return this;

        return Combine(this, values);
    }

    /// <summary>Appends one contributor without boxing this value or allocating a parameter array.</summary>
    /// <param name="value">The CSS contributor to append.</param>
    /// <returns>The combined CSS value.</returns>
    public CssValue<TBuilder> Add(CssValue<TBuilder> value) => CombinePair(this, value);

    /// <summary>
    /// Gets whether this non-empty value affects the generated markup (classes).
    /// </summary>
    public bool AffectsMarkup => !IsEmpty;

    /// <summary>
    /// Determines whether this CssValue is equal to another CssValue.
    /// </summary>
    /// <param name="other">Value to compare with this instance.</param>
    /// <returns>true if this CssValue is equal to another CssValue; otherwise, false.</returns>
    public bool Equals(CssValue<TBuilder> other) =>
        string.Equals(_value ?? string.Empty, other._value ?? string.Empty, StringComparison.Ordinal);

    /// <summary>
    /// Determines whether this CssValue is equal to the specified object.
    /// </summary>
    public override bool Equals(object? obj) => obj is CssValue<TBuilder> o && Equals(o);

    /// <summary>
    /// Returns the hash code for this CssValue.
    /// </summary>
    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(_value ?? string.Empty);

    /// <summary>
    /// Determines whether two CssValue instances are equal.
    /// </summary>
    /// <param name="a">First character sequence to compare.</param>
    /// <param name="b">Second character sequence to compare.</param>
    /// <returns>true if two CssValue instances are equal; otherwise, false.</returns>
    public static bool operator ==(CssValue<TBuilder> a, CssValue<TBuilder> b) => a.Equals(b);

    /// <summary>
    /// Determines whether two CssValue instances are not equal.
    /// </summary>
    /// <param name="a">First character sequence to compare.</param>
    /// <param name="b">Second character sequence to compare.</param>
    /// <returns>true if two CssValue instances are not equal; otherwise, false.</returns>
    public static bool operator !=(CssValue<TBuilder> a, CssValue<TBuilder> b) => !a.Equals(b);

    private static CssValue<TBuilder> CombinePair(CssValue<TBuilder> first, CssValue<TBuilder> second) =>
        new(JoinClasses(first._value, second._value));

    private static string JoinClasses(string? first, string? second)
    {
        if (string.IsNullOrEmpty(first))
            return second ?? string.Empty;
        if (string.IsNullOrEmpty(second))
            return first;
        return string.Concat(first, " ", second);
    }

    private static CssValue<TBuilder> Combine(ReadOnlySpan<CssValue<TBuilder>> values) => Combine(default, values);

    private static CssValue<TBuilder> Combine(CssValue<TBuilder> first, ReadOnlySpan<CssValue<TBuilder>> values)
    {
        if (values.Length == 0)
            return first;
        if (values.Length == 1)
            return CombinePair(first, values[0]);

        var combinedValue = new PooledStringBuilder();
        var hasValue = false;

        try
        {
            AppendSegment(ref combinedValue, ref hasValue, first._value, ' ');


            for (var i = 0; i < values.Length; i++)
            {
                var value = values[i];
                AppendSegment(ref combinedValue, ref hasValue, value._value, ' ');

            }

            return new CssValue<TBuilder>(
                hasValue ? combinedValue.ToString() : string.Empty);
        }
        finally
        {
            combinedValue.Dispose();
        }
    }

    private static void AppendSegment(ref PooledStringBuilder current, ref bool hasValue, string? next, char separator)
    {
        if (string.IsNullOrEmpty(next))
            return;

        if (hasValue)
            current.Append(separator);
        else
            hasValue = true;

        current.Append(next);
    }
}
