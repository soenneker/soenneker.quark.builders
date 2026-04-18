namespace Soenneker.Quark;

[TailwindPrefix("ease-", Responsive = true)]
public sealed class EaseBuilder : ResponsiveUtilityBuilder<EaseBuilder>
{
    internal EaseBuilder(EaseEnum value, BreakpointType? breakpoint = null) : base("ease-", value.Value, breakpoint)
    {
    }

    internal EaseBuilder(string value, BreakpointType? breakpoint = null) : base("ease-", value, breakpoint)
    {
    }

    public EaseBuilder Linear => ChainValue(EaseEnum.Linear.Value);
    public EaseBuilder In => ChainValue(EaseEnum.In.Value);
    public EaseBuilder Out => ChainValue(EaseEnum.Out.Value);
    public EaseBuilder InOut => ChainValue(EaseEnum.InOut.Value);
    public EaseBuilder Token(string value) => ChainValue(value);

    public EaseBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public EaseBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public EaseBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public EaseBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public EaseBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public EaseBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
