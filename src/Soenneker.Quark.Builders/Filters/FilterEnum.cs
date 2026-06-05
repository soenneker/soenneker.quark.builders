using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the filter enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FilterEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly FilterEnum None = new("filter-none");
    /// <summary>
    /// The blur.
    /// </summary>
    public static readonly FilterEnum Blur = new("blur");
    /// <summary>
    /// The brightness.
    /// </summary>
    public static readonly FilterEnum Brightness = new("brightness");
    /// <summary>
    /// The contrast.
    /// </summary>
    public static readonly FilterEnum Contrast = new("contrast");
    /// <summary>
    /// The drop shadow.
    /// </summary>
    public static readonly FilterEnum DropShadow = new("drop-shadow");
    /// <summary>
    /// The grayscale.
    /// </summary>
    public static readonly FilterEnum Grayscale = new("grayscale");
    /// <summary>
    /// The hue rotate.
    /// </summary>
    public static readonly FilterEnum HueRotate = new("hue-rotate");
    /// <summary>
    /// The invert.
    /// </summary>
    public static readonly FilterEnum Invert = new("invert");
    /// <summary>
    /// The opacity.
    /// </summary>
    public static readonly FilterEnum Opacity = new("opacity");
    /// <summary>
    /// The saturate.
    /// </summary>
    public static readonly FilterEnum Saturate = new("saturate");
    /// <summary>
    /// The sepia.
    /// </summary>
    public static readonly FilterEnum Sepia = new("sepia");
}
