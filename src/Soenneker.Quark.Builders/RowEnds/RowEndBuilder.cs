namespace Soenneker.Quark;

[TailwindPrefix("row-end-", Responsive = true)]
public sealed class RowEndBuilder : ResponsiveUtilityBuilder<RowEndBuilder>
{
    internal RowEndBuilder()
    {
    }

    internal RowEndBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public RowEndBuilder Auto => ChainValue("auto");
    public RowEndBuilder At(int value) => ChainValue(value.ToString());
    public RowEndBuilder Token(string value) => ChainValue("row-end-" + value);

}
