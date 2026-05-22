namespace Soenneker.Quark;

[TailwindModifiers(typeof(PlaceItemsAlignBuilder))]
public static partial class PlaceItemsAlign
{
    public static PlaceItemsAlignBuilder Start => new(PlaceItemsAlignEnum.Start);
    public static PlaceItemsAlignBuilder End => new(PlaceItemsAlignEnum.End);
    public static PlaceItemsAlignBuilder Center => new(PlaceItemsAlignEnum.Center);
    public static PlaceItemsAlignBuilder Baseline => new(PlaceItemsAlignEnum.Baseline);
    public static PlaceItemsAlignBuilder Stretch => new(PlaceItemsAlignEnum.Stretch);
    public static PlaceItemsAlignBuilder Token(string value) => new(value.StartsWith("place-items-") ? value : $"place-items-{value}");
}
