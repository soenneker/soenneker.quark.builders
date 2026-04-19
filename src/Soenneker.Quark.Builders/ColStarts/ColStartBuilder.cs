namespace Soenneker.Quark;

[TailwindPrefix("col-start-", Responsive = true)]
public sealed class ColStartBuilder : ResponsiveUtilityBuilder<ColStartBuilder>
{
    internal ColStartBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public ColStartBuilder Auto => ChainValue("auto");
    public ColStartBuilder At(int value) => ChainValue(value.ToString());
    public ColStartBuilder Token(string value) => ChainValue("col-start-" + value);

    public ColStartBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ColStartBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ColStartBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ColStartBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ColStartBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ColStartBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
