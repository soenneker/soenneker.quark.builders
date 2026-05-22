using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BackgroundSizeEnum
{
    public static readonly BackgroundSizeEnum Auto = new("bg-auto");
    public static readonly BackgroundSizeEnum Cover = new("bg-cover");
    public static readonly BackgroundSizeEnum Contain = new("bg-contain");
}
