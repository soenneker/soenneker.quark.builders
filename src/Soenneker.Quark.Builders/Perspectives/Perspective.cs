namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for 3D perspective.
/// </summary>
[TailwindModifiers(typeof(PerspectiveBuilder))]
public static partial class Perspective
{
    /// <summary>Adds <c>perspective-none</c>.</summary>
    public static PerspectiveBuilder None => new("perspective-none");

    /// <summary>Adds <c>perspective-dramatic</c>.</summary>
    public static PerspectiveBuilder Dramatic => new("perspective-dramatic");

    /// <summary>Adds <c>perspective-near</c>.</summary>
    public static PerspectiveBuilder Near => new("perspective-near");

    /// <summary>Adds <c>perspective-normal</c>.</summary>
    public static PerspectiveBuilder Normal => new("perspective-normal");

    /// <summary>Adds <c>perspective-midrange</c>.</summary>
    public static PerspectiveBuilder Midrange => new("perspective-midrange");

    /// <summary>Adds <c>perspective-distant</c>.</summary>
    public static PerspectiveBuilder Distant => new("perspective-distant");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static PerspectiveBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "perspective-"));
}
