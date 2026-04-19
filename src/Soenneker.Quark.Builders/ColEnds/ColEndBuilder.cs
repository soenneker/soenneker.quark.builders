namespace Soenneker.Quark;

[TailwindPrefix("col-end-", Responsive = true)]
public sealed class ColEndBuilder : ResponsiveUtilityBuilder<ColEndBuilder>
{
    internal ColEndBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public ColEndBuilder Auto => ChainValue("auto");
    public ColEndBuilder At(int value) => ChainValue(value.ToString());
    public ColEndBuilder Token(string value) => ChainValue("col-end-" + value);

    public ColEndBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ColEndBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ColEndBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ColEndBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ColEndBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ColEndBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
