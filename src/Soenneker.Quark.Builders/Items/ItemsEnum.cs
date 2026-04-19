using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ItemsEnum
{
    public static readonly ItemsEnum Start = new("items-start");
    public static readonly ItemsEnum End = new("items-end");
    public static readonly ItemsEnum Center = new("items-center");
    public static readonly ItemsEnum Baseline = new("items-baseline");
    public static readonly ItemsEnum Stretch = new("items-stretch");
}
