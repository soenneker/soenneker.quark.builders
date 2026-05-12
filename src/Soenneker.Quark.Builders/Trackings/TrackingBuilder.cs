using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("tracking-", Responsive = true)]
public sealed class TrackingBuilder : CssBuilderBase<TrackingBuilder>
{
    private const string Prefix = "tracking-";
    private readonly List<TrackingRule> _rules = new(4);

    internal TrackingBuilder()
    {
    }

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


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder Chain(TrackingEnum value)
    {
        _rules.Add(new TrackingRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TrackingBuilder Chain(string value)
    {
        _rules.Add(new TrackingRule(value, null, ConsumePendingModifierChain()));
        return this;
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
