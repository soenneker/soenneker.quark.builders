using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll snap stop builder. Tailwind: snap-stop-normal, snap-stop-always.
/// </summary>
[TailwindPrefix("snap-stop-", Responsive = true)]
public sealed class ScrollSnapStopBuilder : CssBuilderBase<ScrollSnapStopBuilder>
{
    private RuleList<ScrollSnapStopRule> _rules;

    internal ScrollSnapStopBuilder()
    {
    }

    internal ScrollSnapStopBuilder(ScrollSnapStopEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollSnapStopRule(value, breakpoint));
    }

    internal ScrollSnapStopBuilder(List<ScrollSnapStopRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public ScrollSnapStopBuilder Normal => Chain(ScrollSnapStopEnum.Normal);
    /// <summary>
    /// Gets or sets always.
    /// </summary>
    public ScrollSnapStopBuilder Always => Chain(ScrollSnapStopEnum.Always);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollSnapStopBuilder Chain(ScrollSnapStopEnum value)
    {
        _rules.Add(new ScrollSnapStopRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScrollSnapStopRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScrollSnapStopRule rule = _rules[i];
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
