using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

public sealed class GrowBuilder : CssBuilderBase
{
    private readonly List<GrowRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal GrowBuilder(GrowEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new GrowRule(value, breakpoint));
    }

    internal GrowBuilder(List<GrowRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public GrowBuilder Is1 => Chain(GrowEnum.Is1);
    public GrowBuilder Is0 => Chain(GrowEnum.Is0);

    public GrowBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public GrowBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public GrowBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public GrowBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public GrowBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public GrowBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GrowBuilder Chain(GrowEnum value)
    {
        _rules.Add(new GrowRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private GrowBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        foreach (GrowRule rule in _rules)
        {
            string cls = rule.Value.Value;
            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);

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
