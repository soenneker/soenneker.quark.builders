namespace Soenneker.Quark;

[TailwindPrefix("delay-", Responsive = true)]
public sealed class DelayBuilder : ResponsiveUtilityBuilder<DelayBuilder>
{
    internal DelayBuilder()
    {
    }

    internal DelayBuilder(DelayEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DelayBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public DelayBuilder Is75 => ChainValue(DelayEnum.Is75Value);
    public DelayBuilder Is100 => ChainValue(DelayEnum.Is100Value);
    public DelayBuilder Is150 => ChainValue(DelayEnum.Is150Value);
    public DelayBuilder Is200 => ChainValue(DelayEnum.Is200Value);
    public DelayBuilder Is300 => ChainValue(DelayEnum.Is300Value);
    public DelayBuilder Is500 => ChainValue(DelayEnum.Is500Value);
    public DelayBuilder Is700 => ChainValue(DelayEnum.Is700Value);
    public DelayBuilder Is1000 => ChainValue(DelayEnum.Is1000Value);
    public DelayBuilder Token(string value) => ChainValue("delay-" + value);

}
