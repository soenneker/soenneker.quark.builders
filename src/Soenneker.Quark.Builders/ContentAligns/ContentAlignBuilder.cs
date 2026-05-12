namespace Soenneker.Quark;

[TailwindPrefix("content-", Responsive = true)]
public sealed class ContentAlignBuilder : ResponsiveUtilityBuilder<ContentAlignBuilder>
{
    internal ContentAlignBuilder()
    {
    }

    internal ContentAlignBuilder(ContentEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal ContentAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public ContentAlignBuilder Normal => ChainValue(ContentEnum.NormalValue);
    public ContentAlignBuilder Center => ChainValue(ContentEnum.CenterValue);
    public ContentAlignBuilder Start => ChainValue(ContentEnum.StartValue);
    public ContentAlignBuilder End => ChainValue(ContentEnum.EndValue);
    public ContentAlignBuilder Between => ChainValue(ContentEnum.BetweenValue);
    public ContentAlignBuilder Around => ChainValue(ContentEnum.AroundValue);
    public ContentAlignBuilder Evenly => ChainValue(ContentEnum.EvenlyValue);
    public ContentAlignBuilder Stretch => ChainValue(ContentEnum.StretchValue);
    public ContentAlignBuilder Baseline => ChainValue(ContentEnum.BaselineValue);
    public ContentAlignBuilder Token(string value) => ChainValue("content-" + value);

}
