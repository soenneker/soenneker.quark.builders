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

    public FlexWrapBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public FlexWrapBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public FlexWrapBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public FlexWrapBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public FlexWrapBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public FlexWrapBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

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
