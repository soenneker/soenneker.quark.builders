namespace Soenneker.Quark;

[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationStyleBuilder : ResponsiveUtilityBuilder<DecorationStyleBuilder>
{
    internal DecorationStyleBuilder(DecorationStyleEnum value, BreakpointType? breakpoint = null) : base("decoration-", value.Value, breakpoint)
    {
    }

    internal DecorationStyleBuilder(string value, BreakpointType? breakpoint = null) : base("decoration-", value, breakpoint)
    {
    }

    public DecorationStyleBuilder Solid => ChainValue(DecorationStyleEnum.Solid.Value);
    public DecorationStyleBuilder Double => ChainValue(DecorationStyleEnum.Double.Value);
    public DecorationStyleBuilder Dotted => ChainValue(DecorationStyleEnum.Dotted.Value);
    public DecorationStyleBuilder Dashed => ChainValue(DecorationStyleEnum.Dashed.Value);
    public DecorationStyleBuilder Wavy => ChainValue(DecorationStyleEnum.Wavy.Value);
    public DecorationStyleBuilder Token(string value) => ChainValue(value);

    public DecorationStyleBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DecorationStyleBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DecorationStyleBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DecorationStyleBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DecorationStyleBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DecorationStyleBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
