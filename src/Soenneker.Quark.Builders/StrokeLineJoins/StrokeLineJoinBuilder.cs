
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
    private RuleList<StrokeLineJoinRule> _rules;

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
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            StrokeLineJoinRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                StrokeLineJoinRule rule = _rules[i];
                writer.Add(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
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

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
