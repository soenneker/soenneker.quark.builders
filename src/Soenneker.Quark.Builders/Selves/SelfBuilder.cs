namespace Soenneker.Quark;

[TailwindPrefix("self-", Responsive = true)]
public sealed class SelfBuilder : ResponsiveUtilityBuilder<SelfBuilder>
{
    internal SelfBuilder(SelfEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal SelfBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public SelfBuilder Auto => ChainValue(SelfEnum.AutoValue);
    public SelfBuilder Start => ChainValue(SelfEnum.StartValue);
    public SelfBuilder End => ChainValue(SelfEnum.EndValue);
    public SelfBuilder Center => ChainValue(SelfEnum.CenterValue);
    public SelfBuilder Stretch => ChainValue(SelfEnum.StretchValue);
    public SelfBuilder Baseline => ChainValue(SelfEnum.BaselineValue);
    public SelfBuilder Token(string value) => ChainValue("self-" + value);

    public SelfBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public SelfBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public SelfBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public SelfBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public SelfBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public SelfBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
