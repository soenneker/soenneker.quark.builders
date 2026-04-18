namespace Soenneker.Quark;

[TailwindPrefix("justify-", Responsive = true)]
public sealed class JustifyBuilder : ResponsiveUtilityBuilder<JustifyBuilder>
{
    internal JustifyBuilder(JustifyEnum value, BreakpointType? breakpoint = null) : base("justify-", value.Value, breakpoint)
    {
    }

    internal JustifyBuilder(string value, BreakpointType? breakpoint = null) : base("justify-", value, breakpoint)
    {
    }

    public JustifyBuilder Normal => ChainValue(JustifyEnum.Normal.Value);
    public JustifyBuilder Start => ChainValue(JustifyEnum.Start.Value);
    public JustifyBuilder End => ChainValue(JustifyEnum.End.Value);
    public JustifyBuilder Center => ChainValue(JustifyEnum.Center.Value);
    public JustifyBuilder Between => ChainValue(JustifyEnum.Between.Value);
    public JustifyBuilder Around => ChainValue(JustifyEnum.Around.Value);
    public JustifyBuilder Evenly => ChainValue(JustifyEnum.Evenly.Value);
    public JustifyBuilder Stretch => ChainValue(JustifyEnum.Stretch.Value);
    public JustifyBuilder Token(string value) => ChainValue(value);

    public JustifyBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public JustifyBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public JustifyBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public JustifyBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public JustifyBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public JustifyBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
