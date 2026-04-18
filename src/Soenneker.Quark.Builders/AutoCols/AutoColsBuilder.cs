namespace Soenneker.Quark;

[TailwindPrefix("auto-cols-", Responsive = true)]
public sealed class AutoColsBuilder : ResponsiveUtilityBuilder<AutoColsBuilder>
{
    internal AutoColsBuilder(string value, BreakpointType? breakpoint = null) : base("auto-cols-", value, breakpoint)
    {
    }

    public AutoColsBuilder Auto => ChainValue("auto");
    public AutoColsBuilder Min => ChainValue("min");
    public AutoColsBuilder Max => ChainValue("max");
    public AutoColsBuilder Fr => ChainValue("fr");
    public AutoColsBuilder Token(string value) => ChainValue(value);

    public AutoColsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public AutoColsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public AutoColsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public AutoColsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public AutoColsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public AutoColsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
