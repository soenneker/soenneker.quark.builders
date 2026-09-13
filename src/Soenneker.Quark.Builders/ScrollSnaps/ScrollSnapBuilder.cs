using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll snap type builder. Tailwind: snap-none, snap-x, snap-y, snap-both, snap-mandatory, snap-proximity.
/// </summary>
[TailwindPrefix("snap-", Responsive = true)]
public sealed class ScrollSnapBuilder : CssBuilderBase<ScrollSnapBuilder>
{
    private RuleList<ScrollSnapRule> _rules;

    internal ScrollSnapBuilder()
    {
    }

    internal ScrollSnapBuilder(ScrollSnapEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollSnapRule(value, breakpoint));
    }

    internal ScrollSnapBuilder(List<ScrollSnapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public ScrollSnapBuilder None => Chain(ScrollSnapEnum.None);
    /// <summary>
    /// Gets or sets x.
    /// </summary>
    public ScrollSnapBuilder X => Chain(ScrollSnapEnum.X);
    /// <summary>
    /// Gets or sets y.
    /// </summary>
    public ScrollSnapBuilder Y => Chain(ScrollSnapEnum.Y);
    /// <summary>
    /// Gets or sets both.
    /// </summary>
    public ScrollSnapBuilder Both => Chain(ScrollSnapEnum.Both);
    /// <summary>
    /// Gets or sets mandatory.
    /// </summary>
    public ScrollSnapBuilder Mandatory => Chain(ScrollSnapEnum.Mandatory);
    /// <summary>
    /// Gets or sets proximity.
    /// </summary>
    public ScrollSnapBuilder Proximity => Chain(ScrollSnapEnum.Proximity);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollSnapBuilder Chain(ScrollSnapEnum value)
    {
        _rules.Add(new ScrollSnapRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            ScrollSnapRule rule = _rules[0];
            return ClassWriter.Render(rule.Value.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                ScrollSnapRule rule = _rules[i];
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
