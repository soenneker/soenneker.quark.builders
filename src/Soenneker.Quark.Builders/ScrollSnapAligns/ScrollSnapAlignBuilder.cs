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

    public ScrollSnapAlignBuilder Start => Chain(ScrollSnapAlignEnum.Start);
    public ScrollSnapAlignBuilder Center => Chain(ScrollSnapAlignEnum.Center);
    public ScrollSnapAlignBuilder End => Chain(ScrollSnapAlignEnum.End);
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

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
