using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Top offset builder. Tailwind: top-*.
/// </summary>
[TailwindPrefix("top-", Responsive = true)]
public sealed class TopBuilder : CssBuilderBase
{
    private readonly List<TopRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal TopBuilder(TopEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TopRule(value.Value, breakpoint));
    }

    internal TopBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TopRule(value, breakpoint));
    }

    internal TopBuilder(List<TopRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public TopBuilder Is0 => Chain(TopEnum.Is0);
    public TopBuilder Is1 => Chain(TopEnum.Is1);
    public TopBuilder Is2 => Chain(TopEnum.Is2);
    public TopBuilder Is3 => Chain(TopEnum.Is3);
    public TopBuilder Is4 => Chain(TopEnum.Is4);
    public TopBuilder Is5 => Chain(TopEnum.Is5);
    public TopBuilder Is8 => Chain(TopEnum.Is8);
    public TopBuilder Is12 => Chain(TopEnum.Is12);
    public TopBuilder Is16 => Chain(TopEnum.Is16);
    public TopBuilder Is24 => Chain(TopEnum.Is24);
    public TopBuilder Auto => Chain(TopEnum.Auto);
    public TopBuilder Px => Chain(TopEnum.Px);
    public TopBuilder Token(string value) => Chain(value.StartsWith("top-") ? value : "top-" + value);

    public TopBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public TopBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public TopBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public TopBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public TopBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public TopBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TopBuilder Chain(TopEnum value)
    {
        _rules.Add(new TopRule(value.Value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TopBuilder Chain(string value)
    {
        _rules.Add(new TopRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TopBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
        foreach (TopRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
