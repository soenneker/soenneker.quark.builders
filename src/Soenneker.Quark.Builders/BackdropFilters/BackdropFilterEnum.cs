using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the backdrop filter enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BackdropFilterEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly BackdropFilterEnum None = new("backdrop-filter-none");
    /// <summary>
    /// The blur.
    /// </summary>
    public static readonly BackdropFilterEnum Blur = new("backdrop-blur");
    /// <summary>
    /// The brightness.
    /// </summary>
    public static readonly BackdropFilterEnum Brightness = new("backdrop-brightness");
    /// <summary>
    /// The contrast.
    /// </summary>
    public static readonly BackdropFilterEnum Contrast = new("backdrop-contrast");
    /// <summary>
    /// The grayscale.
    /// </summary>
    public static readonly BackdropFilterEnum Grayscale = new("backdrop-grayscale");
    /// <summary>
    /// The hue rotate.
    /// </summary>
    public static readonly BackdropFilterEnum HueRotate = new("backdrop-hue-rotate");
    /// <summary>
    /// The invert.
    /// </summary>
    public static readonly BackdropFilterEnum Invert = new("backdrop-invert");
    /// <summary>
    /// The opacity.
    /// </summary>
    public static readonly BackdropFilterEnum Opacity = new("backdrop-opacity");
    /// <summary>
    /// The saturate.
    /// </summary>
    public static readonly BackdropFilterEnum Saturate = new("backdrop-saturate");
    /// <summary>
    /// The sepia.
    /// </summary>
    public static readonly BackdropFilterEnum Sepia = new("backdrop-sepia");
}
