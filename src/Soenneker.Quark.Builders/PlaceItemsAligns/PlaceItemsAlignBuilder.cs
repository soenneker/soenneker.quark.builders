namespace Soenneker.Quark;

[TailwindPrefix("place-items-", Responsive = true)]
public sealed class PlaceItemsAlignBuilder : FinalClassUtilityBuilder<PlaceItemsAlignBuilder>
{
    internal PlaceItemsAlignBuilder() {}
    internal PlaceItemsAlignBuilder(PlaceItemsAlignEnum value) : base(value.Value) {}
    internal PlaceItemsAlignBuilder(string value) : base(value) {}

    public PlaceItemsAlignBuilder Start => ChainClass(PlaceItemsAlignEnum.Start.Value);
    public PlaceItemsAlignBuilder End => ChainClass(PlaceItemsAlignEnum.End.Value);
    public PlaceItemsAlignBuilder Center => ChainClass(PlaceItemsAlignEnum.Center.Value);
    public PlaceItemsAlignBuilder Baseline => ChainClass(PlaceItemsAlignEnum.Baseline.Value);
    public PlaceItemsAlignBuilder Stretch => ChainClass(PlaceItemsAlignEnum.Stretch.Value);
    public PlaceItemsAlignBuilder Token(string value) => ChainClass(value.StartsWith("place-items-") ? value : $"place-items-{value}");
}
