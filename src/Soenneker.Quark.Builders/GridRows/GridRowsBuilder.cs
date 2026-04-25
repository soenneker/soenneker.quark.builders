namespace Soenneker.Quark;

[TailwindPrefix("grid-rows-", Responsive = true)]
public sealed class GridRowsBuilder : ResponsiveUtilityBuilder<GridRowsBuilder>
{
    internal GridRowsBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public GridRowsBuilder Is1 => ChainValue("grid-rows-1");
    public GridRowsBuilder Is2 => ChainValue("grid-rows-2");
    public GridRowsBuilder Is3 => ChainValue("grid-rows-3");
    public GridRowsBuilder Is4 => ChainValue("grid-rows-4");
    public GridRowsBuilder Is5 => ChainValue("grid-rows-5");
    public GridRowsBuilder Is6 => ChainValue("grid-rows-6");
    public GridRowsBuilder None => ChainValue("grid-rows-none");
    public GridRowsBuilder Subgrid => ChainValue("grid-rows-subgrid");
    public GridRowsBuilder Count(int value) => ChainValue("grid-rows-" + value);
    public GridRowsBuilder Token(string value) => ChainValue("grid-rows-" + value);

    public GridRowsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public GridRowsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public GridRowsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public GridRowsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public GridRowsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public GridRowsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
