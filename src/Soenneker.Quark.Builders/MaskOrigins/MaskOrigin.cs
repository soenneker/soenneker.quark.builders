namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask positioning origins.
/// </summary>
[TailwindModifiers(typeof(MaskOriginBuilder))]
public static partial class MaskOrigin
{
    /// <summary>Adds <c>mask-origin-border</c>.</summary>
    public static MaskOriginBuilder Border => new("mask-origin-border");

    /// <summary>Adds <c>mask-origin-padding</c>.</summary>
    public static MaskOriginBuilder Padding => new("mask-origin-padding");

    /// <summary>Adds <c>mask-origin-content</c>.</summary>
    public static MaskOriginBuilder Content => new("mask-origin-content");

    /// <summary>Adds <c>mask-origin-fill</c>.</summary>
    public static MaskOriginBuilder Fill => new("mask-origin-fill");

    /// <summary>Adds <c>mask-origin-stroke</c>.</summary>
    public static MaskOriginBuilder Stroke => new("mask-origin-stroke");

    /// <summary>Adds <c>mask-origin-view</c>.</summary>
    public static MaskOriginBuilder View => new("mask-origin-view");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskOriginBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-origin-"));
}
