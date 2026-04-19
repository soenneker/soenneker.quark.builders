using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("tracking-", Responsive = true)]
public sealed class TrackingBuilder : CssBuilderBase
{
    private const string Prefix = "tracking-";
    private readonly List<TrackingRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal TrackingBuilder(TrackingEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TrackingRule(value.Value, breakpoint));
    }

    internal TrackingBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new TrackingRule(value, breakpoint));
    }

    public TrackingBuilder Tighter => Chain(TrackingEnum.Tighter);
    public TrackingBuilder Tight => Chain(TrackingEnum.Tight);
    public TrackingBuilder Normal => Chain(TrackingEnum.Normal);
    public TrackingBuilder Wide => Chain(TrackingEnum.Wide);
    public TrackingBuilder Wider => Chain(TrackingEnum.Wider);
    public TrackingBuilder Widest => Chain(TrackingEnum.Widest);
    public TrackingBuilder Token(string value) => Chain(Prefix + value);

    public TrackingBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public TrackingBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public TrackingBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public TrackingBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public TrackingBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public TrackingBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder Chain(TrackingEnum value)
    {
        _rules.Add(new TrackingRule(value.Value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder Chain(string value)
    {
        _rules.Add(new TrackingRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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

        for (var i = 0; i < _rules.Count; i++)
        {
            TrackingRule rule = _rules[i];

            if (rule.Value.Length == 0)
                continue;

            string cls = rule.Value;
            string bp = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (bp.Length != 0)
                cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, bp);

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
