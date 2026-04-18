namespace Soenneker.Quark;

[TailwindPrefix("grid-rows-", Responsive = true)]
public sealed class GridRowsBuilder : ResponsiveUtilityBuilder<GridRowsBuilder>
{
    internal GridRowsBuilder(string value, BreakpointType? breakpoint = null) : base("grid-rows-", value, breakpoint)
    {
    }

    public GridRowsBuilder Is1 => ChainValue("1");
    public GridRowsBuilder Is2 => ChainValue("2");
    public GridRowsBuilder Is3 => ChainValue("3");
    public GridRowsBuilder Is4 => ChainValue("4");
    public GridRowsBuilder Is5 => ChainValue("5");
    public GridRowsBuilder Is6 => ChainValue("6");
    public GridRowsBuilder None => ChainValue("none");
    public GridRowsBuilder Subgrid => ChainValue("subgrid");
    public GridRowsBuilder Count(int value) => ChainValue(value.ToString());
    public GridRowsBuilder Token(string value) => ChainValue(value);

    public GridRowsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public GridRowsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public GridRowsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public GridRowsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public GridRowsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public GridRowsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
