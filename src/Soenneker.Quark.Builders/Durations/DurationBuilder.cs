namespace Soenneker.Quark;

[TailwindPrefix("duration-", Responsive = true)]
public sealed class DurationBuilder : ResponsiveUtilityBuilder<DurationBuilder>
{
    internal DurationBuilder(DurationEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DurationBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public DurationBuilder Is75 => ChainValue(DurationEnum.Is75Value);
    public DurationBuilder Is100 => ChainValue(DurationEnum.Is100Value);
    public DurationBuilder Is150 => ChainValue(DurationEnum.Is150Value);
    public DurationBuilder Is200 => ChainValue(DurationEnum.Is200Value);
    public DurationBuilder Is300 => ChainValue(DurationEnum.Is300Value);
    public DurationBuilder Is500 => ChainValue(DurationEnum.Is500Value);
    public DurationBuilder Is700 => ChainValue(DurationEnum.Is700Value);
    public DurationBuilder Is1000 => ChainValue(DurationEnum.Is1000Value);
    public DurationBuilder Token(string value) => ChainValue("duration-" + value);

    public DurationBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DurationBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DurationBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DurationBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DurationBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DurationBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
