namespace Soenneker.Quark;

[TailwindPrefix("col-start-", Responsive = true)]
public sealed class ColStartBuilder : ResponsiveUtilityBuilder<ColStartBuilder>
{
    internal ColStartBuilder()
    {
    }

    internal ColStartBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public ColStartBuilder Is1 => ChainValue("col-start-1");
    public ColStartBuilder Is2 => ChainValue("col-start-2");
    public ColStartBuilder Auto => ChainValue("auto");
    public ColStartBuilder At(int value) => ChainValue(value.ToString());
    public ColStartBuilder Token(string value) => ChainValue("col-start-" + value);

}
