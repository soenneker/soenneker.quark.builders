namespace Soenneker.Quark;

[TailwindPrefix("grid-rows-", Responsive = true)]
public sealed class RowBuilder : ResponsiveUtilityBuilder<RowBuilder>
{
    public RowBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public RowBuilder Is1 => ChainValue("1");
    public RowBuilder Is2 => ChainValue("2");
    public RowBuilder Is3 => ChainValue("3");
    public RowBuilder Is4 => ChainValue("4");
    public RowBuilder Is5 => ChainValue("5");
    public RowBuilder Is6 => ChainValue("6");
    public RowBuilder None => ChainValue("none");
    public RowBuilder Subgrid => ChainValue("subgrid");
    public RowBuilder Count(int value) => ChainValue(value.ToString());
    public RowBuilder Token(string value) => ChainValue("grid-rows-" + value);

    public RowBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public RowBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public RowBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public RowBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public RowBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public RowBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
