using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Left offset builder. Tailwind: left-*.
/// </summary>
[TailwindPrefix("left-", Responsive = true)]
public sealed class LeftBuilder : CssBuilderBase<LeftBuilder>
{
    private readonly List<LeftRule> _rules = new(4);

    internal LeftBuilder()
    {
    }

    internal LeftBuilder(LeftEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeftRule(value.Value, breakpoint));
    }

    internal LeftBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new LeftRule(value, breakpoint));
    }

    internal LeftBuilder(List<LeftRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    public LeftBuilder Is0 => Chain(LeftEnum.Is0);
    public LeftBuilder Is1 => Chain(LeftEnum.Is1);
    public LeftBuilder Is2 => Chain(LeftEnum.Is2);
    public LeftBuilder Is3 => Chain(LeftEnum.Is3);
    public LeftBuilder Is4 => Chain(LeftEnum.Is4);
    public LeftBuilder Is5 => Chain(LeftEnum.Is5);
    public LeftBuilder Is8 => Chain(LeftEnum.Is8);
    public LeftBuilder Is12 => Chain(LeftEnum.Is12);
    public LeftBuilder Is16 => Chain(LeftEnum.Is16);
    public LeftBuilder Is24 => Chain(LeftEnum.Is24);
    public LeftBuilder Auto => Chain(LeftEnum.Auto);
    public LeftBuilder Px => Chain(LeftEnum.Px);
    public LeftBuilder Token(string value) => Chain(value.StartsWith("left-") ? value : "left-" + value);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeftBuilder Chain(LeftEnum value)
    {
        _rules.Add(new LeftRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private LeftBuilder Chain(string value)
    {
        _rules.Add(new LeftRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0) return string.Empty;
        using var sb = new PooledStringBuilder();
        var first = true;
        foreach (LeftRule rule in _rules)
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
