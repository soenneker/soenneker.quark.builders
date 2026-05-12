using System.Collections.Generic;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexDirectionBuilder : ResponsiveUtilityBuilder<FlexDirectionBuilder>
{
    internal FlexDirectionBuilder()
    {
    }

    internal FlexDirectionBuilder(FlexDirectionEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexDirectionBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public FlexDirectionBuilder Row => ChainValue(FlexDirectionEnum.RowValue);
    public FlexDirectionBuilder RowReverse => ChainValue(FlexDirectionEnum.RowReverseValue);
    public FlexDirectionBuilder Col => ChainValue(FlexDirectionEnum.ColValue);
    public FlexDirectionBuilder ColReverse => ChainValue(FlexDirectionEnum.ColReverseValue);
    public FlexDirectionBuilder Token(string value) => ChainValue("flex-" + value);

    public override string ToClass()
    {
        if (Rules.Count == 0)
            return string.Empty;

        using var sb = new PooledStringBuilder();
        var emittedFlexBreakpoints = new HashSet<string>();
        var first = true;

        for (var i = 0; i < Rules.Count; i++)
        {
            UtilityRule rule = Rules[i];

            if (rule.Value.Length == 0)
                continue;

            string modifierChain = GetModifierChain(rule);

            if (emittedFlexBreakpoints.Add(modifierChain))
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

    private static string GetModifierChain(UtilityRule rule)
    {
        string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

        if (breakpoint.Length == 0)
            return rule.ModifierChain ?? string.Empty;

        return rule.ModifierChain is { Length: > 0 } ? $"{breakpoint}:{rule.ModifierChain}" : breakpoint;
    }
}