namespace Soenneker.Quark;

[TailwindPrefix("outline-offset-", Responsive = true)]
public sealed class OutlineOffsetBuilder : ResponsiveUtilityBuilder<OutlineOffsetBuilder>
{
    internal OutlineOffsetBuilder(OutlineOffsetEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal OutlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public OutlineOffsetBuilder Is0 => ChainValue(OutlineOffsetEnum.Is0Value);
    public OutlineOffsetBuilder Is1 => ChainValue(OutlineOffsetEnum.Is1Value);
    public OutlineOffsetBuilder Is2 => ChainValue(OutlineOffsetEnum.Is2Value);
    public OutlineOffsetBuilder Is4 => ChainValue(OutlineOffsetEnum.Is4Value);
    public OutlineOffsetBuilder Is8 => ChainValue(OutlineOffsetEnum.Is8Value);
    public OutlineOffsetBuilder Token(string value) => ChainValue("outline-offset-" + value);

    public OutlineOffsetBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public OutlineOffsetBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public OutlineOffsetBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public OutlineOffsetBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public OutlineOffsetBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public OutlineOffsetBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
