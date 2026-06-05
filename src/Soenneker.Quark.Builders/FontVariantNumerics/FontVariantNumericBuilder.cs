
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
    private readonly List<FontVariantNumericRule> _rules = new(6);

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
    public FontVariantNumericBuilder NormalNums => Chain(FontVariantNumericEnum.NormalNums);
    /// <summary>
    /// Fluent step for `Ordinal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder Ordinal => Chain(FontVariantNumericEnum.Ordinal);
    /// <summary>
    /// Fluent step for `Slashed Zero` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder SlashedZero => Chain(FontVariantNumericEnum.SlashedZero);
    /// <summary>
    /// Fluent step for `Lining Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder LiningNums => Chain(FontVariantNumericEnum.LiningNums);
    /// <summary>
    /// Fluent step for `Oldstyle Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder OldstyleNums => Chain(FontVariantNumericEnum.OldstyleNums);
    /// <summary>
    /// Fluent step for `Proportional Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder ProportionalNums => Chain(FontVariantNumericEnum.ProportionalNums);
    /// <summary>
    /// Fluent step for `Tabular Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder TabularNums => Chain(FontVariantNumericEnum.TabularNums);
    /// <summary>
    /// Fluent step for `Diagonal Fractions` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder DiagonalFractions => Chain(FontVariantNumericEnum.DiagonalFractions);
    /// <summary>
    /// Fluent step for `Stacked Fractions` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public FontVariantNumericBuilder StackedFractions => Chain(FontVariantNumericEnum.StackedFractions);
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
    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            FontVariantNumericRule rule = _rules[i];
            string cls = rule.Value;

            if (cls.Length == 0)
                continue;

            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;
}

