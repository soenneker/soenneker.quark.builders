namespace Soenneker.Quark;

[TailwindPrefix("", Responsive = true)]
public sealed class FontSmoothingBuilder : FinalClassUtilityBuilder<FontSmoothingBuilder>
{
    internal FontSmoothingBuilder() {}
    internal FontSmoothingBuilder(FontSmoothingEnum value) : base(value.Value) {}
    internal FontSmoothingBuilder(string value) : base(value) {}

    public FontSmoothingBuilder Antialiased => ChainClass(FontSmoothingEnum.Antialiased.Value);
    public FontSmoothingBuilder SubpixelAntialiased => ChainClass(FontSmoothingEnum.SubpixelAntialiased.Value);
    public FontSmoothingBuilder Token(string value) => ChainClass(value);
}
