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
    /// Adds an arbitrary font smoothing utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FontSmoothingBuilder Token(string value) => new(value);
}
