
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
    private RuleList<StrokeLineCapRule> _rules;

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

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            StrokeLineCapRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                StrokeLineCapRule rule = _rules[i];
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
