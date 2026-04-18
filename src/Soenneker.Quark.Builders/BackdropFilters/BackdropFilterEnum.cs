using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BackdropFilterEnum
{
    public static readonly BackdropFilterEnum None = new("backdrop-filter-none");
    public static readonly BackdropFilterEnum Blur = new("backdrop-blur");
    public static readonly BackdropFilterEnum Brightness = new("backdrop-brightness");
    public static readonly BackdropFilterEnum Contrast = new("backdrop-contrast");
    public static readonly BackdropFilterEnum Grayscale = new("backdrop-grayscale");
    public static readonly BackdropFilterEnum HueRotate = new("backdrop-hue-rotate");
    public static readonly BackdropFilterEnum Invert = new("backdrop-invert");
    public static readonly BackdropFilterEnum Opacity = new("backdrop-opacity");
    public static readonly BackdropFilterEnum Saturate = new("backdrop-saturate");
    public static readonly BackdropFilterEnum Sepia = new("backdrop-sepia");
}
