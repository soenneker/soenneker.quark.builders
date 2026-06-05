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
    private readonly List<ScrollSnapAlignRule> _rules = new(4);

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

    /// <summary>
    /// Executes the to class operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        foreach (ScrollSnapAlignRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0)
                continue;

            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);

            if (rule.ModifierChain is { Length: > 0 })
                cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

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
