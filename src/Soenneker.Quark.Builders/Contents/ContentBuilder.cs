namespace Soenneker.Quark;

[TailwindPrefix("content-", Responsive = true)]
public sealed class ContentBuilder : ResponsiveUtilityBuilder<ContentBuilder>
{
    internal ContentBuilder(ContentEnum value, BreakpointType? breakpoint = null) : base("content-", value.Value, breakpoint)
    {
    }

    internal ContentBuilder(string value, BreakpointType? breakpoint = null) : base("content-", value, breakpoint)
    {
    }

    public ContentBuilder Normal => ChainValue(ContentEnum.NormalValue);
    public ContentBuilder Center => ChainValue(ContentEnum.CenterValue);
    public ContentBuilder Start => ChainValue(ContentEnum.StartValue);
    public ContentBuilder End => ChainValue(ContentEnum.EndValue);
    public ContentBuilder Between => ChainValue(ContentEnum.BetweenValue);
    public ContentBuilder Around => ChainValue(ContentEnum.AroundValue);
    public ContentBuilder Evenly => ChainValue(ContentEnum.EvenlyValue);
    public ContentBuilder Stretch => ChainValue(ContentEnum.StretchValue);
    public ContentBuilder Baseline => ChainValue(ContentEnum.BaselineValue);
    public ContentBuilder Token(string value) => ChainValue(value);

    public ContentBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ContentBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ContentBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ContentBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ContentBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ContentBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
