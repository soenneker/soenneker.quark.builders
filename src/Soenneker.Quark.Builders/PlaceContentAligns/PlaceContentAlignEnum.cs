using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PlaceContentAlignEnum
{
    public static readonly PlaceContentAlignEnum Center = new("place-content-center");
    public static readonly PlaceContentAlignEnum Start = new("place-content-start");
    public static readonly PlaceContentAlignEnum End = new("place-content-end");
    public static readonly PlaceContentAlignEnum Between = new("place-content-between");
    public static readonly PlaceContentAlignEnum Around = new("place-content-around");
    public static readonly PlaceContentAlignEnum Evenly = new("place-content-evenly");
    public static readonly PlaceContentAlignEnum Stretch = new("place-content-stretch");
    public static readonly PlaceContentAlignEnum Baseline = new("place-content-baseline");
}
