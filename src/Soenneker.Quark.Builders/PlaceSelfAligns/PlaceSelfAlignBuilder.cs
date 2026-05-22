namespace Soenneker.Quark;

[TailwindPrefix("place-self-", Responsive = true)]
public sealed class PlaceSelfAlignBuilder : FinalClassUtilityBuilder<PlaceSelfAlignBuilder>
{
    internal PlaceSelfAlignBuilder() {}
    internal PlaceSelfAlignBuilder(PlaceSelfAlignEnum value) : base(value.Value) {}
    internal PlaceSelfAlignBuilder(string value) : base(value) {}

    public PlaceSelfAlignBuilder Auto => ChainClass(PlaceSelfAlignEnum.Auto.Value);
    public PlaceSelfAlignBuilder Start => ChainClass(PlaceSelfAlignEnum.Start.Value);
    public PlaceSelfAlignBuilder End => ChainClass(PlaceSelfAlignEnum.End.Value);
    public PlaceSelfAlignBuilder Center => ChainClass(PlaceSelfAlignEnum.Center.Value);
    public PlaceSelfAlignBuilder Stretch => ChainClass(PlaceSelfAlignEnum.Stretch.Value);
    public PlaceSelfAlignBuilder Token(string value) => ChainClass(value.StartsWith("place-self-") ? value : $"place-self-{value}");
}
