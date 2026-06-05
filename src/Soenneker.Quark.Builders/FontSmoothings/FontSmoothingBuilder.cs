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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public FontSmoothingBuilder Token(string value) => ChainClass(value);
}
