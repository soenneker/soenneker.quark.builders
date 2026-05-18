
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
    public static BackdropFilterBuilder None => new(BackdropFilterEnum.None);

    /// <summary>
    /// Backdrop blur filter (blur).
    /// </summary>
    public static BackdropFilterBuilder Blur => new(BackdropFilterEnum.Blur);

    /// <summary>
    /// Backdrop brightness filter (brightness).
    /// </summary>
    public static BackdropFilterBuilder Brightness => new(BackdropFilterEnum.Brightness);

    /// <summary>
    /// Backdrop contrast filter (contrast).
    /// </summary>
    public static BackdropFilterBuilder Contrast => new(BackdropFilterEnum.Contrast);

    /// <summary>
    /// Backdrop grayscale filter (grayscale).
    /// </summary>
    public static BackdropFilterBuilder Grayscale => new(BackdropFilterEnum.Grayscale);

    /// <summary>
    /// Backdrop hue rotate filter (hue-rotate).
    /// </summary>
    public static BackdropFilterBuilder HueRotate => new(BackdropFilterEnum.HueRotate);

    /// <summary>
    /// Backdrop invert filter (invert).
    /// </summary>
    public static BackdropFilterBuilder Invert => new(BackdropFilterEnum.Invert);

    /// <summary>
    /// Backdrop opacity filter (opacity).
    /// </summary>
    public static BackdropFilterBuilder Opacity => new(BackdropFilterEnum.Opacity);

    /// <summary>
    /// Backdrop saturate filter (saturate).
    /// </summary>
    public static BackdropFilterBuilder Saturate => new(BackdropFilterEnum.Saturate);

    /// <summary>
    /// Backdrop sepia filter (sepia).
    /// </summary>
    public static BackdropFilterBuilder Sepia => new(BackdropFilterEnum.Sepia);

    /// <summary>
    /// Applies an exact Tailwind backdrop-filter utility token, e.g. "blur-xl" or "backdrop-blur-xl".
    /// </summary>
    public static BackdropFilterBuilder Token(string token) => new(NormalizeToken(token));

    internal static string NormalizeToken(string token)
    {
        if (token.Length == 0)
            return string.Empty;

        return token.StartsWith("backdrop-") ? token : "backdrop-" + token;
    }
}
