using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// End (inset-inline-end) builder. Tailwind: end-*.
/// </summary>
[TailwindPrefix("end-", Responsive = true)]
public sealed class EndBuilder : CssBuilderBase
{
    private readonly List<EndRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal EndBuilder(EndEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new EndRule(value, breakpoint));
    }

    internal EndBuilder(List<EndRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public EndBuilder Is0 => Chain(EndEnum.Is0);
    public EndBuilder Is1 => Chain(EndEnum.Is1);
    public EndBuilder Is2 => Chain(EndEnum.Is2);
    public EndBuilder Is3 => Chain(EndEnum.Is3);
    public EndBuilder Is4 => Chain(EndEnum.Is4);
    public EndBuilder Is5 => Chain(EndEnum.Is5);
    public EndBuilder Auto => Chain(EndEnum.Auto);
    public EndBuilder Px => Chain(EndEnum.Px);

    public EndBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public EndBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public EndBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public EndBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public EndBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private EndBuilder Chain(EndEnum value)
    {
        _rules.Add(new EndRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private EndBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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

    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (EndRule rule in _rules)
        {
            string cls = rule.Value.Value;
            if (cls.Length == 0) continue;
            string b = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (b.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, b);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
