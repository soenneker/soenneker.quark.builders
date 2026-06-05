
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Stroke line cap builder. Tailwind: stroke-cap-auto, stroke-cap-round, stroke-cap-square, stroke-cap-butt.
/// </summary>
[TailwindPrefix("stroke-cap-", Responsive = true)]
public sealed class StrokeLineCapBuilder : CssBuilderBase<StrokeLineCapBuilder>
{
    private readonly List<StrokeLineCapRule> _rules = new(4);

    internal StrokeLineCapBuilder()
    {
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeLineCapBuilder Chain(StrokeLineCapEnum value)
    {
        _rules.Add(new StrokeLineCapRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
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
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
