namespace Soenneker.Quark;

[TailwindPrefix("decoration-", Responsive = true)]
public sealed class DecorationThicknessBuilder : ResponsiveUtilityBuilder<DecorationThicknessBuilder>
{
    internal DecorationThicknessBuilder()
    {
    }

    internal DecorationThicknessBuilder(DecorationThicknessEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DecorationThicknessBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public DecorationThicknessBuilder Auto => ChainValue(DecorationThicknessEnum.AutoValue);
    public DecorationThicknessBuilder FromFont => ChainValue(DecorationThicknessEnum.FromFontValue);
    public DecorationThicknessBuilder Is0 => ChainValue(DecorationThicknessEnum.Is0Value);
    public DecorationThicknessBuilder Is1 => ChainValue(DecorationThicknessEnum.Is1Value);
    public DecorationThicknessBuilder Is2 => ChainValue(DecorationThicknessEnum.Is2Value);
    public DecorationThicknessBuilder Is4 => ChainValue(DecorationThicknessEnum.Is4Value);
    public DecorationThicknessBuilder Is8 => ChainValue(DecorationThicknessEnum.Is8Value);
    public DecorationThicknessBuilder Token(string value) => ChainValue("decoration-" + value);

    public DecorationThicknessBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public DecorationThicknessBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public DecorationThicknessBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public DecorationThicknessBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public DecorationThicknessBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public DecorationThicknessBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
