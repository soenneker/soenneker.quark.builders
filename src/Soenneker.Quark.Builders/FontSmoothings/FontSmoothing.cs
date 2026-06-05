namespace Soenneker.Quark;

/// <summary>
/// Represents the font smoothing.
/// </summary>
[TailwindModifiers(typeof(FontSmoothingBuilder))]
public static partial class FontSmoothing
{
    /// <summary>
    /// Gets or sets antialiased.
    /// </summary>
    public static FontSmoothingBuilder Antialiased => new(FontSmoothingEnum.Antialiased);
    /// <summary>
    /// Gets or sets subpixel antialiased.
    /// </summary>
    public static FontSmoothingBuilder SubpixelAntialiased => new(FontSmoothingEnum.SubpixelAntialiased);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static FontSmoothingBuilder Token(string value) => new(value);
}
