using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FilterEnum
{
    public static readonly FilterEnum None = new("filter-none");
    public static readonly FilterEnum Blur = new("blur");
    public static readonly FilterEnum Brightness = new("brightness");
    public static readonly FilterEnum Contrast = new("contrast");
    public static readonly FilterEnum DropShadow = new("drop-shadow");
    public static readonly FilterEnum Grayscale = new("grayscale");
    public static readonly FilterEnum HueRotate = new("hue-rotate");
    public static readonly FilterEnum Invert = new("invert");
    public static readonly FilterEnum Opacity = new("opacity");
    public static readonly FilterEnum Saturate = new("saturate");
    public static readonly FilterEnum Sepia = new("sepia");
}
