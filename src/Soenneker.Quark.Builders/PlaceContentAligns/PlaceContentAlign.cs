namespace Soenneker.Quark;

[TailwindModifiers(typeof(PlaceContentAlignBuilder))]
public static partial class PlaceContentAlign
{
    public static PlaceContentAlignBuilder Center => new(PlaceContentAlignEnum.Center);
    public static PlaceContentAlignBuilder Start => new(PlaceContentAlignEnum.Start);
    public static PlaceContentAlignBuilder End => new(PlaceContentAlignEnum.End);
    public static PlaceContentAlignBuilder Between => new(PlaceContentAlignEnum.Between);
    public static PlaceContentAlignBuilder Around => new(PlaceContentAlignEnum.Around);
    public static PlaceContentAlignBuilder Evenly => new(PlaceContentAlignEnum.Evenly);
    public static PlaceContentAlignBuilder Stretch => new(PlaceContentAlignEnum.Stretch);
    public static PlaceContentAlignBuilder Baseline => new(PlaceContentAlignEnum.Baseline);
    public static PlaceContentAlignBuilder Token(string value) => new(value.StartsWith("place-content-") ? value : $"place-content-{value}");
}
