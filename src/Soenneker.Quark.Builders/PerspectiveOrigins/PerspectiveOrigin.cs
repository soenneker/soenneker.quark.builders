namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for 3D perspective origins.
/// </summary>
[TailwindModifiers(typeof(PerspectiveOriginBuilder))]
public static partial class PerspectiveOrigin
{
    /// <summary>Adds <c>perspective-origin-center</c>.</summary>
    public static PerspectiveOriginBuilder Center => new("perspective-origin-center");

    /// <summary>Adds <c>perspective-origin-top</c>.</summary>
    public static PerspectiveOriginBuilder Top => new("perspective-origin-top");

    /// <summary>Adds <c>perspective-origin-top-right</c>.</summary>
    public static PerspectiveOriginBuilder TopRight => new("perspective-origin-top-right");

    /// <summary>Adds <c>perspective-origin-right</c>.</summary>
    public static PerspectiveOriginBuilder Right => new("perspective-origin-right");

    /// <summary>Adds <c>perspective-origin-bottom-right</c>.</summary>
    public static PerspectiveOriginBuilder BottomRight => new("perspective-origin-bottom-right");

    /// <summary>Adds <c>perspective-origin-bottom</c>.</summary>
    public static PerspectiveOriginBuilder Bottom => new("perspective-origin-bottom");

    /// <summary>Adds <c>perspective-origin-bottom-left</c>.</summary>
    public static PerspectiveOriginBuilder BottomLeft => new("perspective-origin-bottom-left");

    /// <summary>Adds <c>perspective-origin-left</c>.</summary>
    public static PerspectiveOriginBuilder Left => new("perspective-origin-left");

    /// <summary>Adds <c>perspective-origin-top-left</c>.</summary>
    public static PerspectiveOriginBuilder TopLeft => new("perspective-origin-top-left");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static PerspectiveOriginBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "perspective-origin-"));
}
