
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Stroke line join builder. Tailwind: stroke-join-auto, stroke-join-round, stroke-join-bevel, stroke-join-miter.
/// </summary>
[TailwindPrefix("stroke-join-", Responsive = true)]
public sealed class StrokeLineJoinBuilder : CssBuilderBase<StrokeLineJoinBuilder>
{
    private readonly List<StrokeLineJoinRule> _rules = new(4);

    internal StrokeLineJoinBuilder()
    {
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeLineJoinBuilder Chain(StrokeLineJoinEnum value)
    {
        _rules.Add(new StrokeLineJoinRule(value, null, ConsumePendingModifierChain()));
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
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
