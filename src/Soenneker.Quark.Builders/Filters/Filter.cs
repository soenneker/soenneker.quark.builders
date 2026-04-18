
namespace Soenneker.Quark;

/// <summary>
/// Simplified filter utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
public static class Filter
{
    /// <summary>
    /// No filter (none).
    /// </summary>
    public static FilterBuilder None => new(FilterEnum.None);

    /// <summary>
    /// Blur filter (blur).
    /// </summary>
    public static FilterBuilder Blur => new(FilterEnum.Blur);

    /// <summary>
    /// Brightness filter (brightness).
    /// </summary>
    public static FilterBuilder Brightness => new(FilterEnum.Brightness);

    /// <summary>
    /// Contrast filter (contrast).
    /// </summary>
    public static FilterBuilder Contrast => new(FilterEnum.Contrast);

    /// <summary>
    /// Drop shadow filter (drop-shadow).
    /// </summary>
    public static FilterBuilder DropShadow => new(FilterEnum.DropShadow);

    /// <summary>
    /// Grayscale filter (grayscale).
    /// </summary>
    public static FilterBuilder Grayscale => new(FilterEnum.Grayscale);

    /// <summary>
    /// Hue rotate filter (hue-rotate).
    /// </summary>
    public static FilterBuilder HueRotate => new(FilterEnum.HueRotate);

    /// <summary>
    /// Invert filter (invert).
    /// </summary>
    public static FilterBuilder Invert => new(FilterEnum.Invert);

    /// <summary>
    /// Opacity filter (opacity).
    /// </summary>
    public static FilterBuilder Opacity => new(FilterEnum.Opacity);

    /// <summary>
    /// Saturate filter (saturate).
    /// </summary>
    public static FilterBuilder Saturate => new(FilterEnum.Saturate);

    /// <summary>
    /// Sepia filter (sepia).
    /// </summary>
    public static FilterBuilder Sepia => new(FilterEnum.Sepia);
}
