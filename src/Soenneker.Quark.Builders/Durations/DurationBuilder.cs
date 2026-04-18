namespace Soenneker.Quark;

[TailwindPrefix("duration-", Responsive = true)]
public sealed class DurationBuilder : ResponsiveUtilityBuilder<DurationBuilder>
{
    internal DurationBuilder(DurationEnum value, BreakpointType? breakpoint = null) : base("duration-", value.Value, breakpoint)
    {
    }

    internal DurationBuilder(string value, BreakpointType? breakpoint = null) : base("duration-", value, breakpoint)
    {
    }

    public DurationBuilder Is75 => ChainValue(DurationEnum.Is75.Value);
    public DurationBuilder Is100 => ChainValue(DurationEnum.Is100.Value);
    public DurationBuilder Is150 => ChainValue(DurationEnum.Is150.Value);
    public DurationBuilder Is200 => ChainValue(DurationEnum.Is200.Value);
    public DurationBuilder Is300 => ChainValue(DurationEnum.Is300.Value);
    public DurationBuilder Is500 => ChainValue(DurationEnum.Is500.Value);
    public DurationBuilder Is700 => ChainValue(DurationEnum.Is700.Value);
    public DurationBuilder Is1000 => ChainValue(DurationEnum.Is1000.Value);
    public DurationBuilder Token(string value) => ChainValue(value);

    public DurationBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DurationBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DurationBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DurationBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DurationBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DurationBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
