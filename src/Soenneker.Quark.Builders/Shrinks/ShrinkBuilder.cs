using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

public sealed class ShrinkBuilder : CssBuilderBase
{
    private readonly List<ShrinkRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal ShrinkBuilder(ShrinkEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new ShrinkRule(value, breakpoint));
    }

    internal ShrinkBuilder(List<ShrinkRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public ShrinkBuilder Is1 => Chain(ShrinkEnum.Is1);
    public ShrinkBuilder Is0 => Chain(ShrinkEnum.Is0);

    public ShrinkBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ShrinkBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ShrinkBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ShrinkBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ShrinkBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ShrinkBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShrinkBuilder Chain(ShrinkEnum value)
    {
        _rules.Add(new ShrinkRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShrinkBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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

        foreach (ShrinkRule rule in _rules)
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
