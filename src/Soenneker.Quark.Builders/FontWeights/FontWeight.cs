namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating font weight builders with predefined values.
/// </summary>
[TailwindModifiers(typeof(FontWeightBuilder))]
public static partial class FontWeight
{
    /// <summary>
    /// Gets a font weight builder with extralight value (200).
    /// </summary>
    public static FontWeightBuilder Extralight => new(FontWeightEnum.Extralight);
    /// <summary>
    /// Gets a font weight builder with light value (300).
    /// </summary>
    public static FontWeightBuilder Light => new(FontWeightEnum.Light);
    /// <summary>
    /// Gets a font weight builder with normal value (400).
    /// </summary>
    public static FontWeightBuilder Normal => new(FontWeightEnum.Normal);
    /// <summary>
    /// Gets a font weight builder with medium value (500).
    /// </summary>
    public static FontWeightBuilder Medium => new(FontWeightEnum.Medium);
    /// <summary>
    /// Gets a font weight builder with semibold value (600).
    /// </summary>
    public static FontWeightBuilder Semibold => new(FontWeightEnum.Semibold);
    /// <summary>
    /// Gets a font weight builder with bold value (700).
    /// </summary>
    public static FontWeightBuilder Bold => new(FontWeightEnum.Bold);
    /// <summary>
    /// Gets a font weight builder with extrabold value (800).
    /// </summary>
    public static FontWeightBuilder Extrabold => new(FontWeightEnum.Extrabold);

    /// <summary>
    /// Gets a font weight builder with an arbitrary token such as [450] or font-[450].
    /// </summary>
    public static FontWeightBuilder Token(string value) => new(value);
}
