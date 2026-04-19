using System.Collections.Generic;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexDirectionBuilder : ResponsiveUtilityBuilder<FlexDirectionBuilder>
{
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

    public FlexDirectionBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public FlexDirectionBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public FlexDirectionBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public FlexDirectionBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public FlexDirectionBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public FlexDirectionBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

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

            string breakpoint = BreakpointUtil.GetBreakpointToken(rule.Breakpoint);

            if (emittedFlexBreakpoints.Add(breakpoint))
            {
                string flexClass = breakpoint.Length == 0 ? "flex" : BreakpointUtil.ApplyTailwindBreakpoint("flex", breakpoint);

                if (!first)
                    sb.Append(' ');
                else
                    first = false;

                sb.Append(flexClass);
            }

            string cls = breakpoint.Length == 0 ? rule.Value : BreakpointUtil.ApplyTailwindBreakpoint(rule.Value, breakpoint);

            if (!first)
                sb.Append(' ');
            else
                first = false;

            sb.Append(cls);
        }

        return sb.ToString();
    }
}
