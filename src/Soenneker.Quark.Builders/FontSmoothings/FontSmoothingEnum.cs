using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FontSmoothingEnum
{
    public static readonly FontSmoothingEnum Antialiased = new("antialiased");
    public static readonly FontSmoothingEnum SubpixelAntialiased = new("subpixel-antialiased");
}
