namespace Soenneker.Quark;

[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationThicknessBuilder : ResponsiveUtilityBuilder<DecorationThicknessBuilder>
{
    internal DecorationThicknessBuilder(DecorationThicknessEnum value, BreakpointType? breakpoint = null) : base("decoration-", value.Value, breakpoint)
    {
    }

    internal DecorationThicknessBuilder(string value, BreakpointType? breakpoint = null) : base("decoration-", value, breakpoint)
    {
    }

    public DecorationThicknessBuilder Auto => ChainValue(DecorationThicknessEnum.Auto.Value);
    public DecorationThicknessBuilder FromFont => ChainValue(DecorationThicknessEnum.FromFont.Value);
    public DecorationThicknessBuilder Is0 => ChainValue(DecorationThicknessEnum.Is0.Value);
    public DecorationThicknessBuilder Is1 => ChainValue(DecorationThicknessEnum.Is1.Value);
    public DecorationThicknessBuilder Is2 => ChainValue(DecorationThicknessEnum.Is2.Value);
    public DecorationThicknessBuilder Is4 => ChainValue(DecorationThicknessEnum.Is4.Value);
    public DecorationThicknessBuilder Is8 => ChainValue(DecorationThicknessEnum.Is8.Value);
    public DecorationThicknessBuilder Token(string value) => ChainValue(value);

    public DecorationThicknessBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DecorationThicknessBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DecorationThicknessBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DecorationThicknessBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DecorationThicknessBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DecorationThicknessBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
