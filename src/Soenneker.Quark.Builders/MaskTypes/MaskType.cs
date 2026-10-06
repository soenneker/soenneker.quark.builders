namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for SVG mask types.
/// </summary>
[TailwindModifiers(typeof(MaskTypeBuilder))]
public static partial class MaskType
{
    /// <summary>Adds <c>mask-type-alpha</c>.</summary>
    public static MaskTypeBuilder Alpha => new("mask-type-alpha");

    /// <summary>Adds <c>mask-type-luminance</c>.</summary>
    public static MaskTypeBuilder Luminance => new("mask-type-luminance");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskTypeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-type-"));
}
