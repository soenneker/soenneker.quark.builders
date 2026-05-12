namespace Soenneker.Quark;

[TailwindPrefix("grid-cols-", Responsive = true)]
public sealed class GridColsBuilder : ResponsiveUtilityBuilder<GridColsBuilder>
{
    internal GridColsBuilder()
    {
    }

    internal GridColsBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public GridColsBuilder Is1 => ChainValue("grid-cols-1");
    public GridColsBuilder Is2 => ChainValue("grid-cols-2");
    public GridColsBuilder Is3 => ChainValue("grid-cols-3");
    public GridColsBuilder Is4 => ChainValue("grid-cols-4");
    public GridColsBuilder Is5 => ChainValue("grid-cols-5");
    public GridColsBuilder Is6 => ChainValue("grid-cols-6");
    public GridColsBuilder Is7 => ChainValue("grid-cols-7");
    public GridColsBuilder Is8 => ChainValue("grid-cols-8");
    public GridColsBuilder Is9 => ChainValue("grid-cols-9");
    public GridColsBuilder Is10 => ChainValue("grid-cols-10");
    public GridColsBuilder Is11 => ChainValue("grid-cols-11");
    public GridColsBuilder Is12 => ChainValue("grid-cols-12");
    public GridColsBuilder None => ChainValue("grid-cols-none");
    public GridColsBuilder Subgrid => ChainValue("grid-cols-subgrid");
    public GridColsBuilder Count(int value) => ChainValue("grid-cols-" + value);
    public GridColsBuilder Token(string value) => ChainValue("grid-cols-" + value);

}
