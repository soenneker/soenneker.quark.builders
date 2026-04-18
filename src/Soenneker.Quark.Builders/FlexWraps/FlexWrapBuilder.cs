namespace Soenneker.Quark;

[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexWrapBuilder : ResponsiveUtilityBuilder<FlexWrapBuilder>
{
    internal FlexWrapBuilder(FlexWrapEnum value, BreakpointType? breakpoint = null) : base("flex-", value.Value, breakpoint)
    {
    }

    internal FlexWrapBuilder(string value, BreakpointType? breakpoint = null) : base("flex-", value, breakpoint)
    {
    }

    public FlexWrapBuilder Wrap => ChainValue(FlexWrapEnum.WrapValue);
    public FlexWrapBuilder WrapReverse => ChainValue(FlexWrapEnum.WrapReverseValue);
    public FlexWrapBuilder NoWrap => ChainValue(FlexWrapEnum.NoWrapValue);
    public FlexWrapBuilder Token(string value) => ChainValue(value);

    public FlexWrapBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public FlexWrapBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public FlexWrapBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public FlexWrapBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public FlexWrapBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public FlexWrapBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
