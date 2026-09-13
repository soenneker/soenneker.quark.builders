
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Stroke width builder for SVG/CSS. Tailwind: stroke-0, stroke-1, stroke-2.
/// </summary>
[TailwindPrefix("stroke-", Responsive = true)]
public sealed class StrokeWidthBuilder : CssBuilderBase<StrokeWidthBuilder>
{
    private RuleList<StrokeWidthRule> _rules;

    internal StrokeWidthBuilder()
    {
    }

    internal StrokeWidthBuilder(StrokeWidthEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new StrokeWidthRule(value, breakpoint));
    }

    internal StrokeWidthBuilder(List<StrokeWidthRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Spacing/sizing scale step `0` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 0` for integer spacing utilities unless overridden).
    /// </summary>
    public StrokeWidthBuilder Is0 => Chain(StrokeWidthEnum.Is0);
    /// <summary>
    /// Spacing/sizing scale step `1` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 1` for integer spacing utilities unless overridden).
    /// </summary>
    public StrokeWidthBuilder Is1 => Chain(StrokeWidthEnum.Is1);
    /// <summary>
    /// Spacing/sizing scale step `2` — uses Tailwind’s default spacing scale (each step is typically `0.25rem × 2` for integer spacing utilities unless overridden).
    /// </summary>
    public StrokeWidthBuilder Is2 => Chain(StrokeWidthEnum.Is2);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private StrokeWidthBuilder Chain(StrokeWidthEnum value)
    {
        _rules.Add(new StrokeWidthRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            StrokeWidthRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                StrokeWidthRule rule = _rules[i];
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
