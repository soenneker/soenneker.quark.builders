
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Simplified vertical alignment builder with fluent API for chaining vertical alignment rules.
/// </summary>
[TailwindPrefix("align-", Responsive = true)]
public sealed class VerticalAlignBuilder : CssBuilderBase<VerticalAlignBuilder>
{
    private RuleList<VerticalAlignRule> _rules;

    internal VerticalAlignBuilder()
    {
    }

    internal VerticalAlignBuilder(VerticalAlignEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new VerticalAlignRule(value.Value, breakpoint));
    }

    internal VerticalAlignBuilder(List<VerticalAlignRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Sets the vertical alignment to baseline.
    /// </summary>
    public VerticalAlignBuilder Baseline => Chain(VerticalAlignEnum.Baseline);

    /// <summary>
    /// Sets the vertical alignment to top.
    /// </summary>
    public VerticalAlignBuilder Top => Chain(VerticalAlignEnum.Top);

    /// <summary>
    /// Sets the vertical alignment to middle.
    /// </summary>
    public VerticalAlignBuilder Middle => Chain(VerticalAlignEnum.Middle);

    /// <summary>
    /// Sets the vertical alignment to bottom.
    /// </summary>
    public VerticalAlignBuilder Bottom => Chain(VerticalAlignEnum.Bottom);

    /// <summary>
    /// Sets the vertical alignment to text-top.
    /// </summary>
    public VerticalAlignBuilder TextTop => Chain(VerticalAlignEnum.TextTop);

    /// <summary>
    /// Sets the vertical alignment to text-bottom.
    /// </summary>
    public VerticalAlignBuilder TextBottom => Chain(VerticalAlignEnum.TextBottom);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private VerticalAlignBuilder Chain(VerticalAlignEnum value)
    {
        _rules.Add(new VerticalAlignRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            VerticalAlignRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                VerticalAlignRule rule = _rules[i];
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
    /// Gets the CSS style string for the current configuration.
    /// </summary>
    /// <returns>The CSS style string.</returns>
    public override string ToStyle() => string.Empty;
    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();
}
