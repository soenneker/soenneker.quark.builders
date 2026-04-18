using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ItemsEnum
{
    public static readonly ItemsEnum Start = new("start");
    public static readonly ItemsEnum End = new("end");
    public static readonly ItemsEnum Center = new("center");
    public static readonly ItemsEnum Baseline = new("baseline");
    public static readonly ItemsEnum Stretch = new("stretch");
}
