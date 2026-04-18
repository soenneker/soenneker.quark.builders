namespace Soenneker.Quark;

[TailwindPrefix("self-", Responsive = true)]
public sealed class SelfBuilder : ResponsiveUtilityBuilder<SelfBuilder>
{
    internal SelfBuilder(SelfEnum value, BreakpointType? breakpoint = null) : base("self-", value.Value, breakpoint)
    {
    }

    internal SelfBuilder(string value, BreakpointType? breakpoint = null) : base("self-", value, breakpoint)
    {
    }

    public SelfBuilder Auto => ChainValue(SelfEnum.Auto.Value);
    public SelfBuilder Start => ChainValue(SelfEnum.Start.Value);
    public SelfBuilder End => ChainValue(SelfEnum.End.Value);
    public SelfBuilder Center => ChainValue(SelfEnum.Center.Value);
    public SelfBuilder Stretch => ChainValue(SelfEnum.Stretch.Value);
    public SelfBuilder Baseline => ChainValue(SelfEnum.Baseline.Value);
    public SelfBuilder Token(string value) => ChainValue(value);

    public SelfBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public SelfBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public SelfBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public SelfBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public SelfBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public SelfBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
