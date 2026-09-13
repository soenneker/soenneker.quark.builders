
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind font variant numeric utility builder.
/// </summary>
[TailwindPrefix("normal-nums", Responsive = true)]
public sealed class FontVariantNumericBuilder : CssBuilderBase<FontVariantNumericBuilder>
{
    private RuleList<FontVariantNumericRule> _rules;

    internal FontVariantNumericBuilder()
    {
    }

    internal FontVariantNumericBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontVariantNumericRule(value, breakpoint));
    }

    internal FontVariantNumericBuilder(FontVariantNumericEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new FontVariantNumericRule(value.Value, breakpoint));
    }

    internal FontVariantNumericBuilder(List<FontVariantNumericRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Normal Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder NormalNums => Chain(FontVariantNumericEnum.NormalNumsValue);
    /// <summary>
    /// Fluent step for `Ordinal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder Ordinal => Chain(FontVariantNumericEnum.OrdinalValue);
    /// <summary>
    /// Fluent step for `Slashed Zero` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder SlashedZero => Chain(FontVariantNumericEnum.SlashedZeroValue);
    /// <summary>
    /// Fluent step for `Lining Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder LiningNums => Chain(FontVariantNumericEnum.LiningNumsValue);
    /// <summary>
    /// Fluent step for `Oldstyle Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder OldstyleNums => Chain(FontVariantNumericEnum.OldstyleNumsValue);
    /// <summary>
    /// Fluent step for `Proportional Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder ProportionalNums => Chain(FontVariantNumericEnum.ProportionalNumsValue);
    /// <summary>
    /// Fluent step for `Tabular Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder TabularNums => Chain(FontVariantNumericEnum.TabularNumsValue);
    /// <summary>
    /// Fluent step for `Diagonal Fractions` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder DiagonalFractions => Chain(FontVariantNumericEnum.DiagonalFractionsValue);
    /// <summary>
    /// Fluent step for `Stacked Fractions` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder StackedFractions => Chain(FontVariantNumericEnum.StackedFractionsValue);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontVariantNumericBuilder Chain(string value)
    {
        _rules.Add(new FontVariantNumericRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontVariantNumericBuilder Chain(FontVariantNumericEnum value)
    {
        _rules.Add(new FontVariantNumericRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            FontVariantNumericRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                FontVariantNumericRule rule = _rules[i];
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
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}

