using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll snap align builder. Tailwind: snap-start, snap-center, snap-end, snap-align-none.
/// </summary>
[TailwindPrefix("snap-", Responsive = true)]
public sealed class ScrollSnapAlignBuilder : CssBuilderBase<ScrollSnapAlignBuilder>
{
    private RuleList<ScrollSnapAlignRule> _rules;

    internal ScrollSnapAlignBuilder()
    {
    }

    internal ScrollSnapAlignBuilder(ScrollSnapAlignEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollSnapAlignRule(value, breakpoint));
    }

    internal ScrollSnapAlignBuilder(List<ScrollSnapAlignRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public ScrollSnapAlignBuilder Start => Chain(ScrollSnapAlignEnum.Start);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public ScrollSnapAlignBuilder Center => Chain(ScrollSnapAlignEnum.Center);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public ScrollSnapAlignBuilder End => Chain(ScrollSnapAlignEnum.End);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public ScrollSnapAlignBuilder None => Chain(ScrollSnapAlignEnum.None);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollSnapAlignBuilder Chain(ScrollSnapAlignEnum value)
    {
        _rules.Add(new ScrollSnapAlignRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScrollSnapAlignRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScrollSnapAlignRule rule = _rules[i];
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
