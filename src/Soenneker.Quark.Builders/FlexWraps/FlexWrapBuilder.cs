using System;
using System.Collections.Generic;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexWrapBuilder : ResponsiveUtilityBuilder<FlexWrapBuilder>
{
    internal FlexWrapBuilder()
    {
    }

    internal FlexWrapBuilder(FlexWrapEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexWrapBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public FlexWrapBuilder Wrap => ChainValue(FlexWrapEnum.WrapValue);
    public FlexWrapBuilder WrapReverse => ChainValue(FlexWrapEnum.WrapReverseValue);
    public FlexWrapBuilder NoWrap => ChainValue(FlexWrapEnum.NoWrapValue);
    public FlexWrapBuilder Token(string value) => ChainValue("flex-" + value);


    public override string ToClass()
    {
        if (Rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var first = true;

        for (var i = 0; i < Rules.Count; i++)
        {
            UtilityRule rule = Rules[i];

            if (rule.Value.Length == 0)
                continue;

            string modifierChain = GetModifierChain(rule);

            if (!HasPreviousModifierChain(i, modifierChain))
            {
                string flexClass = modifierChain.Length == 0 ? "flex" : BreakpointUtil.ApplyTailwindModifiers("flex", modifierChain);

                if (!first)
                    sb.Append(' ');
                else
                    first = false;

                sb.Append(flexClass);
            }

            string cls = modifierChain.Length == 0 ? rule.Value : BreakpointUtil.ApplyTailwindModifiers(rule.Value, modifierChain);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }

    private bool HasPreviousModifierChain(int ruleIndex, string modifierChain)
    {
        for (var i = 0; i < ruleIndex; i++)
        {
            if (string.Equals(GetModifierChain(Rules[i]), modifierChain, StringComparison.Ordinal))
                return true;
        }

        return false;
    }

    private static string GetModifierChain(UtilityRule rule)
    {
        string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

        if (breakpoint.Length == 0)
            return rule.ModifierChain ?? string.Empty;

        return rule.ModifierChain is { Length: > 0 } ? $"{breakpoint}:{rule.ModifierChain}" : breakpoint;
    }
}
