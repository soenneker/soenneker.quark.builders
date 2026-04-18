
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Stroke line join builder. Tailwind: stroke-join-auto, stroke-join-round, stroke-join-bevel, stroke-join-miter.
/// </summary>
[TailwindPrefix("stroke-join-", Responsive = true)]
public sealed class StrokeLineJoinBuilder : CssBuilderBase
{
    private readonly List<StrokeLineJoinRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal StrokeLineJoinBuilder(StrokeLineJoinEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new StrokeLineJoinRule(value, breakpoint));
    }

    internal StrokeLineJoinBuilder(List<StrokeLineJoinRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public StrokeLineJoinBuilder Auto => Chain(StrokeLineJoinEnum.Auto);
    /// <summary>
    /// Fluent step for `Round` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public StrokeLineJoinBuilder Round => Chain(StrokeLineJoinEnum.Round);
    /// <summary>
    /// Fluent step for `Bevel` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public StrokeLineJoinBuilder Bevel => Chain(StrokeLineJoinEnum.Bevel);
    /// <summary>
    /// Fluent step for `Miter` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public StrokeLineJoinBuilder Miter => Chain(StrokeLineJoinEnum.Miter);

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint.
    /// </summary>
    public StrokeLineJoinBuilder OnBase => ChainBp(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public StrokeLineJoinBuilder OnSm => ChainBp(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public StrokeLineJoinBuilder OnMd => ChainBp(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public StrokeLineJoinBuilder OnLg => ChainBp(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public StrokeLineJoinBuilder OnXl => ChainBp(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public StrokeLineJoinBuilder On2xl => ChainBp(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeLineJoinBuilder Chain(StrokeLineJoinEnum value)
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new StrokeLineJoinRule(value, breakpoint));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeLineJoinBuilder ChainBp(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (StrokeLineJoinRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
