namespace Soenneker.Quark;

[TailwindPrefix("col-end-", Responsive = true)]
public sealed class ColEndBuilder : ResponsiveUtilityBuilder<ColEndBuilder>
{
    internal ColEndBuilder()
    {
    }

    internal ColEndBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public ColEndBuilder Auto => ChainValue("auto");
    public ColEndBuilder At(int value) => ChainValue(value.ToString());
    public ColEndBuilder Token(string value) => ChainValue("col-end-" + value);

}
