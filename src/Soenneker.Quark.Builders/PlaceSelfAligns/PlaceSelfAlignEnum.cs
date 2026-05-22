using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PlaceSelfAlignEnum
{
    public static readonly PlaceSelfAlignEnum Auto = new("place-self-auto");
    public static readonly PlaceSelfAlignEnum Start = new("place-self-start");
    public static readonly PlaceSelfAlignEnum End = new("place-self-end");
    public static readonly PlaceSelfAlignEnum Center = new("place-self-center");
    public static readonly PlaceSelfAlignEnum Stretch = new("place-self-stretch");
}
