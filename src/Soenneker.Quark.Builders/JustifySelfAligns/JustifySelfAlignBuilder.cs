namespace Soenneker.Quark;

[TailwindPrefix("justify-self-", Responsive = true)]
public sealed class JustifySelfAlignBuilder : ResponsiveUtilityBuilder<JustifySelfAlignBuilder>
{
    internal JustifySelfAlignBuilder()
    {
    }

    internal JustifySelfAlignBuilder(JustifySelfAlignEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal JustifySelfAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public JustifySelfAlignBuilder Auto => ChainValue(JustifySelfAlignEnum.AutoValue);
    public JustifySelfAlignBuilder Start => ChainValue(JustifySelfAlignEnum.StartValue);
    public JustifySelfAlignBuilder End => ChainValue(JustifySelfAlignEnum.EndValue);
    public JustifySelfAlignBuilder Center => ChainValue(JustifySelfAlignEnum.CenterValue);
    public JustifySelfAlignBuilder Stretch => ChainValue(JustifySelfAlignEnum.StretchValue);
    public JustifySelfAlignBuilder Token(string value) => ChainValue("justify-self-" + value);

    public JustifySelfAlignBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public JustifySelfAlignBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public JustifySelfAlignBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public JustifySelfAlignBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public JustifySelfAlignBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public JustifySelfAlignBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
