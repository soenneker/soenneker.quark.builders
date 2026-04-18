
using Soenneker.Utils.PooledStringBuilders;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Soenneker.Quark;

/// <summary>
/// Tailwind font variant numeric utility builder.
/// </summary>
[TailwindPrefix("normal-nums", Responsive = true)]
public sealed class FontVariantNumericBuilder : ICssBuilder
{
    private readonly List<FontVariantNumericRule> _rules = new(6);
    private BreakpointType? _pendingBreakpoint;

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

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint. In Tailwind’s mobile‑first model, unprefixed utilities apply from 0px unless a larger breakpoint overrides them.
    /// </summary>
    public FontVariantNumericBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public FontVariantNumericBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public FontVariantNumericBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public FontVariantNumericBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public FontVariantNumericBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public FontVariantNumericBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontVariantNumericBuilder Chain(string value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new FontVariantNumericRule(value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontVariantNumericBuilder Chain(FontVariantNumericEnum value)
    {
        BreakpointType? bp = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new FontVariantNumericRule(value.Value, bp));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private FontVariantNumericBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    public string ToClass()
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

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;
}
