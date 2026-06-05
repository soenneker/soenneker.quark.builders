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
    private readonly List<ScrollSnapStopRule> _rules = new(4);

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

        foreach (ScrollSnapStopRule rule in _rules)
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
