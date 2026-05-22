namespace Soenneker.Quark;

[TailwindPrefix("box-", Responsive = true)]
public sealed class BoxSizingBuilder : FinalClassUtilityBuilder<BoxSizingBuilder>
{
    internal BoxSizingBuilder() {}
    internal BoxSizingBuilder(BoxSizingEnum value) : base(value.Value) {}
    internal BoxSizingBuilder(string value) : base(value) {}

    public BoxSizingBuilder Border => ChainClass(BoxSizingEnum.Border.Value);
    public BoxSizingBuilder Content => ChainClass(BoxSizingEnum.Content.Value);
    public BoxSizingBuilder Token(string value) => ChainClass(value.StartsWith("box-") ? value : $"box-{value}");
}
