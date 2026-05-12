using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Right offset builder. Tailwind: right-*.
/// </summary>
[TailwindPrefix("right-", Responsive = true)]
public sealed class RightBuilder : CssBuilderBase<RightBuilder>
{
    private readonly List<RightRule> _rules = new(4);

    internal RightBuilder()
    {
    }

    internal RightBuilder(RightEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RightRule(value.Value, breakpoint));
    }

    internal RightBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new RightRule(value, breakpoint));
    }

    internal RightBuilder(List<RightRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public RightBuilder Is0 => Chain(RightEnum.Is0);
    public RightBuilder Is1 => Chain(RightEnum.Is1);
    public RightBuilder Is2 => Chain(RightEnum.Is2);
    public RightBuilder Is3 => Chain(RightEnum.Is3);
    public RightBuilder Is4 => Chain(RightEnum.Is4);
    public RightBuilder Is5 => Chain(RightEnum.Is5);
    public RightBuilder Is8 => Chain(RightEnum.Is8);
    public RightBuilder Is12 => Chain(RightEnum.Is12);
    public RightBuilder Is16 => Chain(RightEnum.Is16);
    public RightBuilder Is24 => Chain(RightEnum.Is24);
    public RightBuilder Auto => Chain(RightEnum.Auto);
    public RightBuilder Px => Chain(RightEnum.Px);
    public RightBuilder Token(string value) => Chain(value.StartsWith("right-") ? value : "right-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RightBuilder Chain(RightEnum value)
    {
        _rules.Add(new RightRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private RightBuilder Chain(string value)
    {
        _rules.Add(new RightRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (RightRule rule in _rules)
        {
            string cls = rule.Value;
            if (cls.Length == 0) continue;
            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);
            if (breakpoint.Length != 0) cls = BreakpointUtil.ApplyTailwindBreakpoint(cls, breakpoint);
            if (rule.ModifierChain is { Length: > 0 }) cls = BreakpointUtil.ApplyTailwindModifiers(cls, rule.ModifierChain);
            if (!first) sb.Append(' ');
            else first = false;
            sb.Append(cls);
        }
        return sb.ToString();
    }

    public override string ToStyle() => string.Empty;

    public override string ToString() => ToClass();
}
