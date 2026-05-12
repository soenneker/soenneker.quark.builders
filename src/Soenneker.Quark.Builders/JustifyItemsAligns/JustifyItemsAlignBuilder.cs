namespace Soenneker.Quark;

[TailwindPrefix("justify-items-", Responsive = true)]
public sealed class JustifyItemsAlignBuilder : ResponsiveUtilityBuilder<JustifyItemsAlignBuilder>
{
    internal JustifyItemsAlignBuilder()
    {
    }

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

}
