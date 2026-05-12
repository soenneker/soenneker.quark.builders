using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

public sealed class ShrinkBuilder : CssBuilderBase<ShrinkBuilder>
{
    private readonly List<ShrinkRule> _rules = new(4);

    internal ShrinkBuilder()
    {
    }

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


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ShrinkBuilder Chain(ShrinkEnum value)
    {
        _rules.Add(new ShrinkRule(value, null, ConsumePendingModifierChain()));
        return this;
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
