namespace Soenneker.Quark;

[TailwindPrefix("place-content-", Responsive = true)]
public sealed class PlaceContentAlignBuilder : FinalClassUtilityBuilder<PlaceContentAlignBuilder>
{
    internal PlaceContentAlignBuilder() {}
    internal PlaceContentAlignBuilder(PlaceContentAlignEnum value) : base(value.Value) {}
    internal PlaceContentAlignBuilder(string value) : base(value) {}

    public PlaceContentAlignBuilder Center => ChainClass(PlaceContentAlignEnum.Center.Value);
    public PlaceContentAlignBuilder Start => ChainClass(PlaceContentAlignEnum.Start.Value);
    public PlaceContentAlignBuilder End => ChainClass(PlaceContentAlignEnum.End.Value);
    public PlaceContentAlignBuilder Between => ChainClass(PlaceContentAlignEnum.Between.Value);
    public PlaceContentAlignBuilder Around => ChainClass(PlaceContentAlignEnum.Around.Value);
    public PlaceContentAlignBuilder Evenly => ChainClass(PlaceContentAlignEnum.Evenly.Value);
    public PlaceContentAlignBuilder Stretch => ChainClass(PlaceContentAlignEnum.Stretch.Value);
    public PlaceContentAlignBuilder Baseline => ChainClass(PlaceContentAlignEnum.Baseline.Value);
    public PlaceContentAlignBuilder Token(string value) => ChainClass(value.StartsWith("place-content-") ? value : $"place-content-{value}");
}
