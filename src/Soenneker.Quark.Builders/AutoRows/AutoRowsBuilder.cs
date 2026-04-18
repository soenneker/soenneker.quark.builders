namespace Soenneker.Quark;

[TailwindPrefix("auto-rows-", Responsive = true)]
public sealed class AutoRowsBuilder : ResponsiveUtilityBuilder<AutoRowsBuilder>
{
    internal AutoRowsBuilder(string value, BreakpointType? breakpoint = null) : base("auto-rows-", value, breakpoint)
    {
    }

    public AutoRowsBuilder Auto => ChainValue("auto");
    public AutoRowsBuilder Min => ChainValue("min");
    public AutoRowsBuilder Max => ChainValue("max");
    public AutoRowsBuilder Fr => ChainValue("fr");
    public AutoRowsBuilder Token(string value) => ChainValue(value);

    public AutoRowsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public AutoRowsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public AutoRowsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public AutoRowsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public AutoRowsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public AutoRowsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
