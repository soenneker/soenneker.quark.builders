namespace Soenneker.Quark;

[TailwindPrefix("", Responsive = true)]
public sealed class DecorationLineBuilder : ResponsiveUtilityBuilder<DecorationLineBuilder>
{
    internal DecorationLineBuilder()
    {
    }

    internal DecorationLineBuilder(DecorationLineEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DecorationLineBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public DecorationLineBuilder None => ChainValue(DecorationLineEnum.NoneValue);
    public DecorationLineBuilder Underline => ChainValue(DecorationLineEnum.UnderlineValue);
    public DecorationLineBuilder LineThrough => ChainValue(DecorationLineEnum.LineThroughValue);
    public DecorationLineBuilder Overline => ChainValue(DecorationLineEnum.OverlineValue);
    public DecorationLineBuilder Token(string value) => ChainValue(value);

}
