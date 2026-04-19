namespace Soenneker.Quark;

[TailwindPrefix("justify-items-", Responsive = true)]
public sealed class JustifyItemsAlignBuilder : ResponsiveUtilityBuilder<JustifyItemsAlignBuilder>
{
    internal JustifyItemsAlignBuilder(JustifyItemsAlignEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal JustifyItemsAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public JustifyItemsAlignBuilder Normal => ChainValue(JustifyItemsAlignEnum.NormalValue);
    public JustifyItemsAlignBuilder Start => ChainValue(JustifyItemsAlignEnum.StartValue);
    public JustifyItemsAlignBuilder End => ChainValue(JustifyItemsAlignEnum.EndValue);
    public JustifyItemsAlignBuilder Center => ChainValue(JustifyItemsAlignEnum.CenterValue);
    public JustifyItemsAlignBuilder Stretch => ChainValue(JustifyItemsAlignEnum.StretchValue);
    public JustifyItemsAlignBuilder Token(string value) => ChainValue("justify-items-" + value);

    public JustifyItemsAlignBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public JustifyItemsAlignBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public JustifyItemsAlignBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public JustifyItemsAlignBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public JustifyItemsAlignBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public JustifyItemsAlignBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
