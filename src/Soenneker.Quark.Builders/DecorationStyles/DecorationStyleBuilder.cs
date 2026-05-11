namespace Soenneker.Quark;

[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationStyleBuilder : ResponsiveUtilityBuilder<DecorationStyleBuilder>
{
    internal DecorationStyleBuilder()
    {
    }

    internal DecorationStyleBuilder(DecorationStyleEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DecorationStyleBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public DecorationStyleBuilder Solid => ChainValue(DecorationStyleEnum.SolidValue);
    public DecorationStyleBuilder Double => ChainValue(DecorationStyleEnum.DoubleValue);
    public DecorationStyleBuilder Dotted => ChainValue(DecorationStyleEnum.DottedValue);
    public DecorationStyleBuilder Dashed => ChainValue(DecorationStyleEnum.DashedValue);
    public DecorationStyleBuilder Wavy => ChainValue(DecorationStyleEnum.WavyValue);
    public DecorationStyleBuilder Token(string value) => ChainValue("decoration-" + value);

    public DecorationStyleBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DecorationStyleBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DecorationStyleBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DecorationStyleBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DecorationStyleBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DecorationStyleBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
