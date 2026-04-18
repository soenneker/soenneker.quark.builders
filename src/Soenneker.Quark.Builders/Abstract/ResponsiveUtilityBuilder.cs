using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

public abstract class ResponsiveUtilityBuilder<TBuilder> : ICssBuilder where TBuilder : ResponsiveUtilityBuilder<TBuilder>
{
    private readonly string _prefix;
    private readonly List<UtilityRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    protected ResponsiveUtilityBuilder(string prefix, string value, BreakpointType? breakpoint = null)
    {
        _prefix = prefix;

        if (value.Length != 0)
            _rules.Add(new UtilityRule(value, breakpoint));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TBuilder ChainValue(string value)
    {
        _rules.Add(new UtilityRule(value, ConsumePendingBreakpoint()));
        return (TBuilder)this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    protected TBuilder SetPendingBreakpoint(BreakpointType breakpoint)
    {
        _pendingBreakpoint = breakpoint;
        return (TBuilder)this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BreakpointType? ConsumePendingBreakpoint()
    {
        BreakpointType? breakpoint = _pendingBreakpoint;
        _pendingBreakpoint = null;
        return breakpoint;
    }

    public virtual string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < _rules.Count; i++)
        {
            UtilityRule rule = _rules[i];

            if (rule.Value.Length == 0)
                continue;

            string cls = _prefix.Length == 0 ? rule.Value : _prefix + rule.Value;
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

    public virtual string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}

internal readonly record struct UtilityRule(string Value, BreakpointType? Breakpoint);
