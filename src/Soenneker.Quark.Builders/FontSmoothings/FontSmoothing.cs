namespace Soenneker.Quark;

[TailwindModifiers(typeof(FontSmoothingBuilder))]
public static partial class FontSmoothing
{
    public static FontSmoothingBuilder Antialiased => new(FontSmoothingEnum.Antialiased);
    public static FontSmoothingBuilder SubpixelAntialiased => new(FontSmoothingEnum.SubpixelAntialiased);
    public static FontSmoothingBuilder Token(string value) => new(value);
}
