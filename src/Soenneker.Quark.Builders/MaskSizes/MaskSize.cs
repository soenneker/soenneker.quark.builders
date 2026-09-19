namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for mask sizing.
/// </summary>
[TailwindModifiers(typeof(MaskSizeBuilder))]
public static partial class MaskSize
{
    /// <summary>Adds <c>mask-auto</c>.</summary>
    public static MaskSizeBuilder Auto => new("mask-auto");

    /// <summary>Adds <c>mask-cover</c>.</summary>
    public static MaskSizeBuilder Cover => new("mask-cover");

    /// <summary>Adds <c>mask-contain</c>.</summary>
    public static MaskSizeBuilder Contain => new("mask-contain");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static MaskSizeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "mask-"));
}
