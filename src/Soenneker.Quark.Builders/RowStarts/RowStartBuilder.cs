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

    public RowStartBuilder Is1 => ChainValue("row-start-1");
    public RowStartBuilder Auto => ChainValue("auto");
    public RowStartBuilder At(int value) => ChainValue(value.ToString());
    public RowStartBuilder Token(string value) => ChainValue("row-start-" + value);

}
