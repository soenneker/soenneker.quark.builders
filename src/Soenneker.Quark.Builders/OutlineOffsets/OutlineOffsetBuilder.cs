namespace Soenneker.Quark;

[TailwindPrefix("outline-offset-", Responsive = true)]
public sealed class OutlineOffsetBuilder : ResponsiveUtilityBuilder<OutlineOffsetBuilder>
{
    internal OutlineOffsetBuilder()
    {
    }

    internal OutlineOffsetBuilder(OutlineOffsetEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal OutlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public OutlineOffsetBuilder Is0 => ChainValue(OutlineOffsetEnum.Is0Value);
    public OutlineOffsetBuilder Is1 => ChainValue(OutlineOffsetEnum.Is1Value);
    public OutlineOffsetBuilder Is2 => ChainValue(OutlineOffsetEnum.Is2Value);
    public OutlineOffsetBuilder Is4 => ChainValue(OutlineOffsetEnum.Is4Value);
    public OutlineOffsetBuilder Is8 => ChainValue(OutlineOffsetEnum.Is8Value);
    public OutlineOffsetBuilder Token(string value) => ChainValue("outline-offset-" + value);

}
