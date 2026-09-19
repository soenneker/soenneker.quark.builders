namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask clipping.
/// </summary>
[TailwindModifiers(typeof(MaskClipBuilder))]
public static partial class MaskClip
{
    /// <summary>Adds <c>mask-clip-border</c>.</summary>
    public static MaskClipBuilder Border => new("mask-clip-border");

    /// <summary>Adds <c>mask-clip-padding</c>.</summary>
    public static MaskClipBuilder Padding => new("mask-clip-padding");

    /// <summary>Adds <c>mask-clip-content</c>.</summary>
    public static MaskClipBuilder Content => new("mask-clip-content");

    /// <summary>Adds <c>mask-clip-fill</c>.</summary>
    public static MaskClipBuilder Fill => new("mask-clip-fill");

    /// <summary>Adds <c>mask-clip-stroke</c>.</summary>
    public static MaskClipBuilder Stroke => new("mask-clip-stroke");

    /// <summary>Adds <c>mask-clip-view</c>.</summary>
    public static MaskClipBuilder View => new("mask-clip-view");

    /// <summary>Adds <c>mask-no-clip</c>.</summary>
    public static MaskClipBuilder None => new("mask-no-clip");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskClipBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
}
