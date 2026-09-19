namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for browser color schemes.
/// </summary>
[TailwindModifiers(typeof(ColorSchemeBuilder))]
public static partial class ColorScheme
{
    /// <summary>Adds <c>scheme-normal</c>.</summary>
    public static ColorSchemeBuilder Normal => new("scheme-normal");

    /// <summary>Adds <c>scheme-light</c>.</summary>
    public static ColorSchemeBuilder Light => new("scheme-light");

    /// <summary>Adds <c>scheme-dark</c>.</summary>
    public static ColorSchemeBuilder Dark => new("scheme-dark");

    /// <summary>Adds <c>scheme-light-dark</c>.</summary>
    public static ColorSchemeBuilder LightDark => new("scheme-light-dark");

    /// <summary>Adds <c>scheme-only-light</c>.</summary>
    public static ColorSchemeBuilder OnlyLight => new("scheme-only-light");

    /// <summary>Adds <c>scheme-only-dark</c>.</summary>
    public static ColorSchemeBuilder OnlyDark => new("scheme-only-dark");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ColorSchemeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "scheme-"));
}
