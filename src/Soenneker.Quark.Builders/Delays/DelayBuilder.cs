namespace Soenneker.Quark;

[TailwindPrefix("delay-", Responsive = true)]
public sealed class DelayBuilder : ResponsiveUtilityBuilder<DelayBuilder>
{
    internal DelayBuilder(DelayEnum value, BreakpointType? breakpoint = null) : base("delay-", value.Value, breakpoint)
    {
    }

    internal DelayBuilder(string value, BreakpointType? breakpoint = null) : base("delay-", value, breakpoint)
    {
    }

    public DelayBuilder Is75 => ChainValue(DelayEnum.Is75.Value);
    public DelayBuilder Is100 => ChainValue(DelayEnum.Is100.Value);
    public DelayBuilder Is150 => ChainValue(DelayEnum.Is150.Value);
    public DelayBuilder Is200 => ChainValue(DelayEnum.Is200.Value);
    public DelayBuilder Is300 => ChainValue(DelayEnum.Is300.Value);
    public DelayBuilder Is500 => ChainValue(DelayEnum.Is500.Value);
    public DelayBuilder Is700 => ChainValue(DelayEnum.Is700.Value);
    public DelayBuilder Is1000 => ChainValue(DelayEnum.Is1000.Value);
    public DelayBuilder Token(string value) => ChainValue(value);

    public DelayBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DelayBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DelayBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DelayBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DelayBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DelayBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
