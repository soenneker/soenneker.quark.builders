using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// End (inset-inline-end) builder. Tailwind: end-*.
/// </summary>
[TailwindPrefix("end-", Responsive = true)]
public sealed class EndBuilder : CssBuilderBase<EndBuilder>
{
    private readonly List<EndRule> _rules = new(4);

    internal EndBuilder()
    {
    }

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


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private EndBuilder Chain(EndEnum value)
    {
        _rules.Add(new EndRule(value, null, ConsumePendingModifierChain()));
        return this;
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
