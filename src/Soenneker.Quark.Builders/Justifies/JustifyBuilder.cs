namespace Soenneker.Quark;

[TailwindPrefix("justify-", Responsive = true)]
public sealed class JustifyBuilder : ResponsiveUtilityBuilder<JustifyBuilder>
{
    internal JustifyBuilder()
    {
    }

    internal JustifyBuilder(JustifyEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal JustifyBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public JustifyBuilder Normal => ChainValue(JustifyEnum.NormalValue);
    public JustifyBuilder Start => ChainValue(JustifyEnum.StartValue);
    public JustifyBuilder End => ChainValue(JustifyEnum.EndValue);
    public JustifyBuilder Center => ChainValue(JustifyEnum.CenterValue);
    public JustifyBuilder Between => ChainValue(JustifyEnum.BetweenValue);
    public JustifyBuilder Around => ChainValue(JustifyEnum.AroundValue);
    public JustifyBuilder Evenly => ChainValue(JustifyEnum.EvenlyValue);
    public JustifyBuilder Stretch => ChainValue(JustifyEnum.StretchValue);
    public JustifyBuilder Token(string value) => ChainValue("justify-" + value);

    public JustifyBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public JustifyBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public JustifyBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public JustifyBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public JustifyBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public JustifyBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
