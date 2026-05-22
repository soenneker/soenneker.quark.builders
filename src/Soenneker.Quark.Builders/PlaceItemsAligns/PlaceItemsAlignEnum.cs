using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PlaceItemsAlignEnum
{
    public static readonly PlaceItemsAlignEnum Start = new("place-items-start");
    public static readonly PlaceItemsAlignEnum End = new("place-items-end");
    public static readonly PlaceItemsAlignEnum Center = new("place-items-center");
    public static readonly PlaceItemsAlignEnum Baseline = new("place-items-baseline");
    public static readonly PlaceItemsAlignEnum Stretch = new("place-items-stretch");
}
