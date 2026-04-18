using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Scroll snap type builder. Tailwind: snap-none, snap-x, snap-y, snap-both, snap-mandatory, snap-proximity.
/// </summary>
[TailwindPrefix("snap-", Responsive = true)]
public sealed class ScrollSnapBuilder : ICssBuilder
{
    private readonly List<ScrollSnapRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ScrollSnapBuilder(ScrollSnapEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ScrollSnapRule(value, breakpoint));
    }

    internal ScrollSnapBuilder(List<ScrollSnapRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public ScrollSnapBuilder None => Chain(ScrollSnapEnum.None);
    public ScrollSnapBuilder X => Chain(ScrollSnapEnum.X);
    public ScrollSnapBuilder Y => Chain(ScrollSnapEnum.Y);
    public ScrollSnapBuilder Both => Chain(ScrollSnapEnum.Both);
    public ScrollSnapBuilder Mandatory => Chain(ScrollSnapEnum.Mandatory);
    public ScrollSnapBuilder Proximity => Chain(ScrollSnapEnum.Proximity);

    public ScrollSnapBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ScrollSnapBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ScrollSnapBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ScrollSnapBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ScrollSnapBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollSnapBuilder Chain(ScrollSnapEnum value)
    {
        _rules.Add(new ScrollSnapRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ScrollSnapBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        foreach (ScrollSnapRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0)
                continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (!first)
                sb.Append(' ');
            else
                first = false;
            sb.Append(cls);
        }

        return sb.ToString();
    }

    public string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
