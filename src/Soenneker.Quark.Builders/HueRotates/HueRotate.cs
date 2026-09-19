namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for huerotate filters.
/// </summary>
[TailwindModifiers(typeof(HueRotateBuilder))]
public static partial class HueRotate
{
    /// <summary>Adds <c>hue-rotate-0</c>.</summary>
    public static HueRotateBuilder Is0 => new("hue-rotate-0");

    /// <summary>Adds <c>hue-rotate-15</c>.</summary>
    public static HueRotateBuilder Is15 => new("hue-rotate-15");

    /// <summary>Adds <c>hue-rotate-30</c>.</summary>
    public static HueRotateBuilder Is30 => new("hue-rotate-30");

    /// <summary>Adds <c>hue-rotate-60</c>.</summary>
    public static HueRotateBuilder Is60 => new("hue-rotate-60");

    /// <summary>Adds <c>hue-rotate-90</c>.</summary>
    public static HueRotateBuilder Is90 => new("hue-rotate-90");

    /// <summary>Adds <c>hue-rotate-180</c>.</summary>
    public static HueRotateBuilder Is180 => new("hue-rotate-180");

    /// <summary>Adds <c>-hue-rotate-90</c>.</summary>
    public static HueRotateBuilder Negative90 => new("-hue-rotate-90");

    /// <summary>Adds <c>-hue-rotate-180</c>.</summary>
    public static HueRotateBuilder Negative180 => new("-hue-rotate-180");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static HueRotateBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "hue-rotate-"));
}
