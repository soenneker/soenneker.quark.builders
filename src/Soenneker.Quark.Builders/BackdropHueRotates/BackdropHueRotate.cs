namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop huerotate filters.
/// </summary>
[TailwindModifiers(typeof(BackdropHueRotateBuilder))]
public static partial class BackdropHueRotate
{
    /// <summary>Adds <c>backdrop-hue-rotate-0</c>.</summary>
    public static BackdropHueRotateBuilder Is0 => new("backdrop-hue-rotate-0");

    /// <summary>Adds <c>backdrop-hue-rotate-15</c>.</summary>
    public static BackdropHueRotateBuilder Is15 => new("backdrop-hue-rotate-15");

    /// <summary>Adds <c>backdrop-hue-rotate-30</c>.</summary>
    public static BackdropHueRotateBuilder Is30 => new("backdrop-hue-rotate-30");

    /// <summary>Adds <c>backdrop-hue-rotate-60</c>.</summary>
    public static BackdropHueRotateBuilder Is60 => new("backdrop-hue-rotate-60");

    /// <summary>Adds <c>backdrop-hue-rotate-90</c>.</summary>
    public static BackdropHueRotateBuilder Is90 => new("backdrop-hue-rotate-90");

    /// <summary>Adds <c>backdrop-hue-rotate-180</c>.</summary>
    public static BackdropHueRotateBuilder Is180 => new("backdrop-hue-rotate-180");

    /// <summary>Adds <c>-backdrop-hue-rotate-90</c>.</summary>
    public static BackdropHueRotateBuilder Negative90 => new("-backdrop-hue-rotate-90");

    /// <summary>Adds <c>-backdrop-hue-rotate-180</c>.</summary>
    public static BackdropHueRotateBuilder Negative180 => new("-backdrop-hue-rotate-180");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropHueRotateBuilder Token(string value) => new(UtilityToken.WithSignedPrefix(value, "backdrop-hue-rotate-"));
}
