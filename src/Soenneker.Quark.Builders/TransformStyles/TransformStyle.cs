namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for 3D transform rendering.
/// </summary>
[TailwindModifiers(typeof(TransformStyleBuilder))]
public static partial class TransformStyle
{
    /// <summary>Adds <c>transform-flat</c>.</summary>
    public static TransformStyleBuilder Flat => new("transform-flat");

    /// <summary>Adds <c>transform-3d</c>.</summary>
    public static TransformStyleBuilder Preserve3D => new("transform-3d");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TransformStyleBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "transform-"));
}
