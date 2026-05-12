namespace Soenneker.Quark;

[TailwindPrefix("text-", Responsive = true)]
public sealed class TextAlignBuilder : ResponsiveUtilityBuilder<TextAlignBuilder>
{
    internal TextAlignBuilder()
    {
    }

    internal TextAlignBuilder(TextAlignmentEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal TextAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public TextAlignBuilder Start => ChainValue(TextAlignmentEnum.StartValue);
    public TextAlignBuilder Center => ChainValue(TextAlignmentEnum.CenterValue);
    public TextAlignBuilder End => ChainValue(TextAlignmentEnum.EndValue);
    public TextAlignBuilder Token(string value) => ChainValue("text-" + value);

}
