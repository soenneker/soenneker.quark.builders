namespace Soenneker.Quark;

[TailwindPrefix("row-end-", Responsive = true)]
public sealed class RowEndBuilder : ResponsiveUtilityBuilder<RowEndBuilder>
{
    internal RowEndBuilder(string value, BreakpointType? breakpoint = null) : base("row-end-", value, breakpoint)
    {
    }

    public RowEndBuilder Auto => ChainValue("auto");
    public RowEndBuilder At(int value) => ChainValue(value.ToString());
    public RowEndBuilder Token(string value) => ChainValue(value);

    public RowEndBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public RowEndBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public RowEndBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public RowEndBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public RowEndBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public RowEndBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
