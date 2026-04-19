namespace Soenneker.Quark;

[TailwindPrefix("grid-cols-", Responsive = true)]
public sealed class GridColsBuilder : ResponsiveUtilityBuilder<GridColsBuilder>
{
    internal GridColsBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public GridColsBuilder Is1 => ChainValue("1");
    public GridColsBuilder Is2 => ChainValue("2");
    public GridColsBuilder Is3 => ChainValue("3");
    public GridColsBuilder Is4 => ChainValue("4");
    public GridColsBuilder Is5 => ChainValue("5");
    public GridColsBuilder Is6 => ChainValue("6");
    public GridColsBuilder Is7 => ChainValue("7");
    public GridColsBuilder Is8 => ChainValue("8");
    public GridColsBuilder Is9 => ChainValue("9");
    public GridColsBuilder Is10 => ChainValue("10");
    public GridColsBuilder Is11 => ChainValue("11");
    public GridColsBuilder Is12 => ChainValue("12");
    public GridColsBuilder None => ChainValue("none");
    public GridColsBuilder Subgrid => ChainValue("subgrid");
    public GridColsBuilder Count(int value) => ChainValue(value.ToString());
    public GridColsBuilder Token(string value) => ChainValue("grid-cols-" + value);

    public GridColsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public GridColsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public GridColsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public GridColsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public GridColsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public GridColsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
