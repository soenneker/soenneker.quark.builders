namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask source interpretation.
/// </summary>
[TailwindModifiers(typeof(MaskModeBuilder))]
public static partial class MaskMode
{
    /// <summary>Adds <c>mask-alpha</c>.</summary>
    public static MaskModeBuilder Alpha => new("mask-alpha");

    /// <summary>Adds <c>mask-luminance</c>.</summary>
    public static MaskModeBuilder Luminance => new("mask-luminance");

    /// <summary>Adds <c>mask-match</c>.</summary>
    public static MaskModeBuilder Match => new("mask-match");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskModeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
}
