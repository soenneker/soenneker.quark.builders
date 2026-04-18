
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Stroke line cap builder. Tailwind: stroke-cap-auto, stroke-cap-round, stroke-cap-square, stroke-cap-butt.
/// </summary>
[TailwindPrefix("stroke-cap-", Responsive = true)]
public sealed class StrokeLineCapBuilder : CssBuilderBase
{
    private readonly List<StrokeLineCapRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal StrokeLineCapBuilder(StrokeLineCapEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new StrokeLineCapRule(value, breakpoint));
    }

    internal StrokeLineCapBuilder(List<StrokeLineCapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public StrokeLineCapBuilder Auto => Chain(StrokeLineCapEnum.Auto);
    /// <summary>
    /// Fluent step for `Round` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public StrokeLineCapBuilder Round => Chain(StrokeLineCapEnum.Round);
    /// <summary>
    /// Fluent step for `Square` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public StrokeLineCapBuilder Square => Chain(StrokeLineCapEnum.Square);
    /// <summary>
    /// Fluent step for `Butt` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public StrokeLineCapBuilder Butt => Chain(StrokeLineCapEnum.Butt);

    /// <summary>
    /// Scopes the next utility to the default (unprefixed) breakpoint.
    /// </summary>
    public StrokeLineCapBuilder OnBase => ChainBp(BreakpointType.Base);
    /// <summary>
    /// Applies the preceding utility from the `sm` breakpoint and up (`sm:` prefix). Tailwind default: `min-width: 40rem` (640px).
    /// </summary>
    public StrokeLineCapBuilder OnSm => ChainBp(BreakpointType.Sm);
    /// <summary>
    /// Applies from the `md` breakpoint and up (`md:`). Tailwind default: `min-width: 48rem` (768px).
    /// </summary>
    public StrokeLineCapBuilder OnMd => ChainBp(BreakpointType.Md);
    /// <summary>
    /// Applies from the `lg` breakpoint and up (`lg:`). Tailwind default: `min-width: 64rem` (1024px).
    /// </summary>
    public StrokeLineCapBuilder OnLg => ChainBp(BreakpointType.Lg);
    /// <summary>
    /// Applies from the `xl` breakpoint and up (`xl:`). Tailwind default: `min-width: 80rem` (1280px).
    /// </summary>
    public StrokeLineCapBuilder OnXl => ChainBp(BreakpointType.Xl);
    /// <summary>
    /// Applies from the `2xl` breakpoint and up (`2xl:`). Tailwind default: `min-width: 96rem` (1536px).
    /// </summary>
    public StrokeLineCapBuilder On2xl => ChainBp(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeLineCapBuilder Chain(StrokeLineCapEnum value)
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        _rules.Add(new StrokeLineCapRule(value, breakpoint));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeLineCapBuilder ChainBp(BreakpointType bp)
    {
        _pendingBreakpoint = bp;
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (StrokeLineCapRule rule in _rules)
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
