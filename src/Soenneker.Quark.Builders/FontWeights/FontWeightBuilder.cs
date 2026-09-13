
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// High-performance font weight builder with fluent API for chaining font weight rules.
/// </summary>
[TailwindPrefix("font-", Responsive = true)]
public sealed class FontWeightBuilder : CssBuilderBase<FontWeightBuilder>
{
    private RuleList<FontWeightRule> _rules;

    internal FontWeightBuilder()
    {
    }

    internal FontWeightBuilder(FontWeightEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontWeightRule(value.Value, breakpoint));
    }

    internal FontWeightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontWeightRule(NormalizeFontWeightClass(value), breakpoint));
    }

    internal FontWeightBuilder(List<FontWeightRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the font weight to extralight.
    /// </summary>
    public FontWeightBuilder Extralight => Chain(FontWeightEnum.ExtralightValue);
    /// <summary>
    /// Sets the font weight to light.
    /// </summary>
    public FontWeightBuilder Light => Chain(FontWeightEnum.LightValue);
    /// <summary>
    /// Sets the font weight to normal.
    /// </summary>
    public FontWeightBuilder Normal => Chain(FontWeightEnum.NormalValue);
    /// <summary>
    /// Sets the font weight to medium.
    /// </summary>
    public FontWeightBuilder Medium => Chain(FontWeightEnum.MediumValue);
    /// <summary>
    /// Sets the font weight to semibold.
    /// </summary>
    public FontWeightBuilder Semibold => Chain(FontWeightEnum.SemiboldValue);
    /// <summary>
    /// Sets the font weight to bold.
    /// </summary>
    public FontWeightBuilder Bold => Chain(FontWeightEnum.BoldValue);
    /// <summary>
    /// Sets the font weight to extrabold.
    /// </summary>
    public FontWeightBuilder Extrabold => Chain(FontWeightEnum.ExtraboldValue);
    /// <summary>
    /// Sets an arbitrary font weight token such as [450] or font-[450].
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FontWeightBuilder Token(string value) => Chain(NormalizeFontWeightClass(value));


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontWeightBuilder Chain(FontWeightEnum value)
    {
        BreakpointType? bp = null;
        _rules.Add(new FontWeightRule(value.Value, bp, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontWeightBuilder Chain(string value)
    {
        BreakpointType? bp = null;
        _rules.Add(new FontWeightRule(value, bp, ConsumePendingModifierChain()));
        return this;
    }


    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FontWeightRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FontWeightRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;
    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();

    private static string NormalizeFontWeightClass(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        return value.StartsWith("font-") ? value : "font-" + value;
    }
}
