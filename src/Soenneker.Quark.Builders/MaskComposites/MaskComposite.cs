namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask composition.
/// </summary>
[TailwindModifiers(typeof(MaskCompositeBuilder))]
public static partial class MaskComposite
{
    /// <summary>Adds <c>mask-add</c>.</summary>
    public static MaskCompositeBuilder Add => new("mask-add");

    /// <summary>Adds <c>mask-subtract</c>.</summary>
    public static MaskCompositeBuilder Subtract => new("mask-subtract");

    /// <summary>Adds <c>mask-intersect</c>.</summary>
    public static MaskCompositeBuilder Intersect => new("mask-intersect");

    /// <summary>Adds <c>mask-exclude</c>.</summary>
    public static MaskCompositeBuilder Exclude => new("mask-exclude");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskCompositeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
}
