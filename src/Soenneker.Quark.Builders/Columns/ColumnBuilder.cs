namespace Soenneker.Quark;

[TailwindPrefix("grid-cols-", Responsive = true)]
public sealed class ColumnBuilder : ResponsiveUtilityBuilder<ColumnBuilder>
{
    public ColumnBuilder(string value, BreakpointType? breakpoint = null) : base("grid-cols-", value, breakpoint)
    {
    }

    public ColumnBuilder Is1 => ChainValue("1");
    public ColumnBuilder Is2 => ChainValue("2");
    public ColumnBuilder Is3 => ChainValue("3");
    public ColumnBuilder Is4 => ChainValue("4");
    public ColumnBuilder Is5 => ChainValue("5");
    public ColumnBuilder Is6 => ChainValue("6");
    public ColumnBuilder Is7 => ChainValue("7");
    public ColumnBuilder Is8 => ChainValue("8");
    public ColumnBuilder Is9 => ChainValue("9");
    public ColumnBuilder Is10 => ChainValue("10");
    public ColumnBuilder Is11 => ChainValue("11");
    public ColumnBuilder Is12 => ChainValue("12");
    public ColumnBuilder None => ChainValue("none");
    public ColumnBuilder Subgrid => ChainValue("subgrid");
    public ColumnBuilder Count(int value) => ChainValue(value.ToString());
    public ColumnBuilder Token(string value) => ChainValue(value);

    public ColumnBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ColumnBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ColumnBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ColumnBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ColumnBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ColumnBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
