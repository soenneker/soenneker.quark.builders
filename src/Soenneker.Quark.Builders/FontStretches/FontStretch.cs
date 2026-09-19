namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for font stretching.
/// </summary>
[TailwindModifiers(typeof(FontStretchBuilder))]
public static partial class FontStretch
{
    /// <summary>Adds <c>font-stretch-ultra-condensed</c>.</summary>
    public static FontStretchBuilder UltraCondensed => new("font-stretch-ultra-condensed");

    /// <summary>Adds <c>font-stretch-extra-condensed</c>.</summary>
    public static FontStretchBuilder ExtraCondensed => new("font-stretch-extra-condensed");

    /// <summary>Adds <c>font-stretch-condensed</c>.</summary>
    public static FontStretchBuilder Condensed => new("font-stretch-condensed");

    /// <summary>Adds <c>font-stretch-semi-condensed</c>.</summary>
    public static FontStretchBuilder SemiCondensed => new("font-stretch-semi-condensed");

    /// <summary>Adds <c>font-stretch-normal</c>.</summary>
    public static FontStretchBuilder Normal => new("font-stretch-normal");

    /// <summary>Adds <c>font-stretch-semi-expanded</c>.</summary>
    public static FontStretchBuilder SemiExpanded => new("font-stretch-semi-expanded");

    /// <summary>Adds <c>font-stretch-expanded</c>.</summary>
    public static FontStretchBuilder Expanded => new("font-stretch-expanded");

    /// <summary>Adds <c>font-stretch-extra-expanded</c>.</summary>
    public static FontStretchBuilder ExtraExpanded => new("font-stretch-extra-expanded");

    /// <summary>Adds <c>font-stretch-ultra-expanded</c>.</summary>
    public static FontStretchBuilder UltraExpanded => new("font-stretch-ultra-expanded");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static FontStretchBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "font-stretch-"));
}
