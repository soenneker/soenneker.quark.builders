namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for 3D perspective origins, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("perspective-origin-", Responsive = true)]
public sealed class PerspectiveOriginBuilder : FinalClassUtilityBuilder<PerspectiveOriginBuilder>
{
    internal PerspectiveOriginBuilder()
    {
    }

    internal PerspectiveOriginBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>perspective-origin-center</c>.</summary>
    public PerspectiveOriginBuilder Center => ChainClass("perspective-origin-center");

    /// <summary>Adds <c>perspective-origin-top</c>.</summary>
    public PerspectiveOriginBuilder Top => ChainClass("perspective-origin-top");

    /// <summary>Adds <c>perspective-origin-top-right</c>.</summary>
    public PerspectiveOriginBuilder TopRight => ChainClass("perspective-origin-top-right");

    /// <summary>Adds <c>perspective-origin-right</c>.</summary>
    public PerspectiveOriginBuilder Right => ChainClass("perspective-origin-right");

    /// <summary>Adds <c>perspective-origin-bottom-right</c>.</summary>
    public PerspectiveOriginBuilder BottomRight => ChainClass("perspective-origin-bottom-right");

    /// <summary>Adds <c>perspective-origin-bottom</c>.</summary>
    public PerspectiveOriginBuilder Bottom => ChainClass("perspective-origin-bottom");

    /// <summary>Adds <c>perspective-origin-bottom-left</c>.</summary>
    public PerspectiveOriginBuilder BottomLeft => ChainClass("perspective-origin-bottom-left");

    /// <summary>Adds <c>perspective-origin-left</c>.</summary>
    public PerspectiveOriginBuilder Left => ChainClass("perspective-origin-left");

    /// <summary>Adds <c>perspective-origin-top-left</c>.</summary>
    public PerspectiveOriginBuilder TopLeft => ChainClass("perspective-origin-top-left");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public PerspectiveOriginBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "perspective-origin-"));
}
