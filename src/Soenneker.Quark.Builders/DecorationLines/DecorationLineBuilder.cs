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

    public DecorationLineBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DecorationLineBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DecorationLineBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DecorationLineBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DecorationLineBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DecorationLineBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
