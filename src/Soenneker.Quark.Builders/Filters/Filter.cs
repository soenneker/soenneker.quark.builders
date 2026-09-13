
namespace Soenneker.Quark;

/// <summary>
/// Simplified filter utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(FilterBuilder))]
public static partial class Filter
{
    /// <summary>
    /// No filter (none).
    /// </summary>
    public static FilterBuilder None => new(FilterEnum.NoneValue);

    /// <summary>
    /// Blur filter (blur).
    /// </summary>
    public static FilterBuilder Blur => new(FilterEnum.BlurValue);

    /// <summary>
    /// Brightness filter (brightness).
    /// </summary>
    public static FilterBuilder Brightness => new(FilterEnum.BrightnessValue);

    /// <summary>
    /// Contrast filter (contrast).
    /// </summary>
    public static FilterBuilder Contrast => new(FilterEnum.ContrastValue);

    /// <summary>
    /// Drop shadow filter (drop-shadow).
    /// </summary>
    public static FilterBuilder DropShadow => new(FilterEnum.DropShadowValue);

    /// <summary>
    /// Grayscale filter (grayscale).
    /// </summary>
    public static FilterBuilder Grayscale => new(FilterEnum.GrayscaleValue);

    /// <summary>
    /// Hue rotate filter (hue-rotate).
    /// </summary>
    public static FilterBuilder HueRotate => new(FilterEnum.HueRotateValue);

    /// <summary>
    /// Invert filter (invert).
    /// </summary>
    public static FilterBuilder Invert => new(FilterEnum.InvertValue);

    /// <summary>
    /// Opacity filter (opacity).
    /// </summary>
    public static FilterBuilder Opacity => new(FilterEnum.OpacityValue);

    /// <summary>
    /// Saturate filter (saturate).
    /// </summary>
    public static FilterBuilder Saturate => new(FilterEnum.SaturateValue);

    /// <summary>
    /// Sepia filter (sepia).
    /// </summary>
    public static FilterBuilder Sepia => new(FilterEnum.SepiaValue);
}
