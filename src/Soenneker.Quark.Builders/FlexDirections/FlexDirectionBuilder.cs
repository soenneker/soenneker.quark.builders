namespace Soenneker.Quark;

[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexDirectionBuilder : ResponsiveUtilityBuilder<FlexDirectionBuilder>
{
    internal FlexDirectionBuilder(FlexDirectionEnum value, BreakpointType? breakpoint = null) : base("flex-", value.Value, breakpoint)
    {
    }

    internal FlexDirectionBuilder(string value, BreakpointType? breakpoint = null) : base("flex-", value, breakpoint)
    {
    }

    public FlexDirectionBuilder Row => ChainValue(FlexDirectionEnum.Row.Value);
    public FlexDirectionBuilder RowReverse => ChainValue(FlexDirectionEnum.RowReverse.Value);
    public FlexDirectionBuilder Col => ChainValue(FlexDirectionEnum.Col.Value);
    public FlexDirectionBuilder ColReverse => ChainValue(FlexDirectionEnum.ColReverse.Value);
    public FlexDirectionBuilder Token(string value) => ChainValue(value);

    public FlexDirectionBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public FlexDirectionBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public FlexDirectionBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public FlexDirectionBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public FlexDirectionBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public FlexDirectionBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
