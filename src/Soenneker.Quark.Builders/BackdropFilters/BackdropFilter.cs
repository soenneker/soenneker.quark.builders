
namespace Soenneker.Quark;

/// <summary>
/// Simplified backdrop filter utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(BackdropFilterBuilder))]
public static partial class BackdropFilter
{
    /// <summary>
    /// No backdrop filter (none).
    /// </summary>
    public static BackdropFilterBuilder None => new(BackdropFilterEnum.NoneValue);

    /// <summary>
    /// Backdrop blur filter (blur).
    /// </summary>
    public static BackdropFilterBuilder Blur => new(BackdropFilterEnum.BlurValue);

    /// <summary>
    /// Backdrop brightness filter (brightness).
    /// </summary>
    public static BackdropFilterBuilder Brightness => new(BackdropFilterEnum.BrightnessValue);

    /// <summary>
    /// Backdrop contrast filter (contrast).
    /// </summary>
    public static BackdropFilterBuilder Contrast => new(BackdropFilterEnum.ContrastValue);

    /// <summary>
    /// Backdrop grayscale filter (grayscale).
    /// </summary>
    public static BackdropFilterBuilder Grayscale => new(BackdropFilterEnum.GrayscaleValue);

    /// <summary>
    /// Backdrop hue rotate filter (hue-rotate).
    /// </summary>
    public static BackdropFilterBuilder HueRotate => new(BackdropFilterEnum.HueRotateValue);

    /// <summary>
    /// Backdrop invert filter (invert).
    /// </summary>
    public static BackdropFilterBuilder Invert => new(BackdropFilterEnum.InvertValue);

    /// <summary>
    /// Backdrop opacity filter (opacity).
    /// </summary>
    public static BackdropFilterBuilder Opacity => new(BackdropFilterEnum.OpacityValue);

    /// <summary>
    /// Backdrop saturate filter (saturate).
    /// </summary>
    public static BackdropFilterBuilder Saturate => new(BackdropFilterEnum.SaturateValue);

    /// <summary>
    /// Backdrop sepia filter (sepia).
    /// </summary>
    public static BackdropFilterBuilder Sepia => new(BackdropFilterEnum.SepiaValue);

    /// <summary>
    /// Applies an exact Tailwind backdrop-filter utility token, e.g. "blur-xl" or "backdrop-blur-xl".
    /// </summary>
    /// <param name="token">Arbitrary utility token to append.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackdropFilterBuilder Token(string token) => new(NormalizeToken(token));

    internal static string NormalizeToken(string token)
    {
        if (token.Length == 0)
            return string.Empty;

        return token.StartsWith("backdrop-") ? token : "backdrop-" + token;
    }
}
