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

    public ContentBuilder Normal => ChainValue(ContentEnum.Normal.Value);
    public ContentBuilder Center => ChainValue(ContentEnum.Center.Value);
    public ContentBuilder Start => ChainValue(ContentEnum.Start.Value);
    public ContentBuilder End => ChainValue(ContentEnum.End.Value);
    public ContentBuilder Between => ChainValue(ContentEnum.Between.Value);
    public ContentBuilder Around => ChainValue(ContentEnum.Around.Value);
    public ContentBuilder Evenly => ChainValue(ContentEnum.Evenly.Value);
    public ContentBuilder Stretch => ChainValue(ContentEnum.Stretch.Value);
    public ContentBuilder Baseline => ChainValue(ContentEnum.Baseline.Value);
    public ContentBuilder Token(string value) => ChainValue(value);

    public ContentBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ContentBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ContentBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ContentBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ContentBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ContentBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
