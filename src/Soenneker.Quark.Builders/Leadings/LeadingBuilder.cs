using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("leading-", Responsive = true)]
public sealed class LeadingBuilder : CssBuilderBase
{
    private const string Prefix = "leading-";
    private readonly List<LeadingRule> _rules = new(4);
    private BreakpointType? _pendingBreakpoint;

    internal LeadingBuilder(LeadingEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeadingRule(value.Value, breakpoint));
    }

    internal LeadingBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeadingRule(value, breakpoint));
    }

    public LeadingBuilder None => Chain(LeadingEnum.None);
    public LeadingBuilder Tight => Chain(LeadingEnum.Tight);
    public LeadingBuilder Snug => Chain(LeadingEnum.Snug);
    public LeadingBuilder Normal => Chain(LeadingEnum.Normal);
    public LeadingBuilder Relaxed => Chain(LeadingEnum.Relaxed);
    public LeadingBuilder Loose => Chain(LeadingEnum.Loose);
    public LeadingBuilder Is0 => Chain(LeadingEnum.Is0);
    public LeadingBuilder Is1 => Chain(LeadingEnum.Is1);
    public LeadingBuilder Is2 => Chain(LeadingEnum.Is2);
    public LeadingBuilder Is3 => Chain(LeadingEnum.Is3);
    public LeadingBuilder Is4 => Chain(LeadingEnum.Is4);
    public LeadingBuilder Is5 => Chain(LeadingEnum.Is5);
    public LeadingBuilder Is6 => Chain(LeadingEnum.Is6);
    public LeadingBuilder Is7 => Chain(LeadingEnum.Is7);
    public LeadingBuilder Is8 => Chain(LeadingEnum.Is8);
    public LeadingBuilder Is9 => Chain(LeadingEnum.Is9);
    public LeadingBuilder Is10 => Chain(LeadingEnum.Is10);
    public LeadingBuilder Token(string value) => Chain(Prefix + value);

    public LeadingBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public LeadingBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public LeadingBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public LeadingBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public LeadingBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public LeadingBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeadingBuilder Chain(LeadingEnum value)
    {
        _rules.Add(new LeadingRule(value.Value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeadingBuilder Chain(string value)
    {
        _rules.Add(new LeadingRule(value, ConsumePendingBreakpoint()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeadingBuilder SetPendingBreakpoint(BreakpointType breakpoint)
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
            LeadingRule rule = _rules[i];

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
