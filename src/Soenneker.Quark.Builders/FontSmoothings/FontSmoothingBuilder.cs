namespace Soenneker.Quark;

/// <summary>
/// Represents the font smoothing builder.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class FontSmoothingBuilder : FinalClassUtilityBuilder<FontSmoothingBuilder>
{
    internal FontSmoothingBuilder() {}
    internal FontSmoothingBuilder(FontSmoothingEnum value) : base(value.Value) {}
    internal FontSmoothingBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets antialiased.
    /// </summary>
    public FontSmoothingBuilder Antialiased => ChainClass(FontSmoothingEnum.Antialiased.Value);
    /// <summary>
    /// Gets or sets subpixel antialiased.
    /// </summary>
    public FontSmoothingBuilder SubpixelAntialiased => ChainClass(FontSmoothingEnum.SubpixelAntialiased.Value);
    /// <summary>
    /// Adds an arbitrary font smoothing utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public FontSmoothingBuilder Token(string value) => ChainClass(value);
}
