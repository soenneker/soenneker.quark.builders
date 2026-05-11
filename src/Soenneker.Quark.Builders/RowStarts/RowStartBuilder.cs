namespace Soenneker.Quark;

[TailwindPrefix("row-start-", Responsive = true)]
public sealed class RowStartBuilder : ResponsiveUtilityBuilder<RowStartBuilder>
{
    internal RowStartBuilder()
    {
    }

    internal RowStartBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public RowStartBuilder Auto => ChainValue("auto");
    public RowStartBuilder At(int value) => ChainValue(value.ToString());
    public RowStartBuilder Token(string value) => ChainValue("row-start-" + value);

    public RowStartBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public RowStartBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public RowStartBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public RowStartBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public RowStartBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public RowStartBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
