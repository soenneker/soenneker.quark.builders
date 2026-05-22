namespace Soenneker.Quark;

[TailwindModifiers(typeof(PlaceSelfAlignBuilder))]
public static partial class PlaceSelfAlign
{
    public static PlaceSelfAlignBuilder Auto => new(PlaceSelfAlignEnum.Auto);
    public static PlaceSelfAlignBuilder Start => new(PlaceSelfAlignEnum.Start);
    public static PlaceSelfAlignBuilder End => new(PlaceSelfAlignEnum.End);
    public static PlaceSelfAlignBuilder Center => new(PlaceSelfAlignEnum.Center);
    public static PlaceSelfAlignBuilder Stretch => new(PlaceSelfAlignEnum.Stretch);
    public static PlaceSelfAlignBuilder Token(string value) => new(value.StartsWith("place-self-") ? value : $"place-self-{value}");
}
