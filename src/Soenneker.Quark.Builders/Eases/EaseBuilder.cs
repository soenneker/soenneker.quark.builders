namespace Soenneker.Quark;

[TailwindPrefix("ease-", Responsive = true)]
public sealed class EaseBuilder : ResponsiveUtilityBuilder<EaseBuilder>
{
    internal EaseBuilder(EaseEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal EaseBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public EaseBuilder Linear => ChainValue(EaseEnum.LinearValue);
    public EaseBuilder In => ChainValue(EaseEnum.InValue);
    public EaseBuilder Out => ChainValue(EaseEnum.OutValue);
    public EaseBuilder InOut => ChainValue(EaseEnum.InOutValue);
    public EaseBuilder Token(string value) => ChainValue("ease-" + value);

    public EaseBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public EaseBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public EaseBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public EaseBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public EaseBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public EaseBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
