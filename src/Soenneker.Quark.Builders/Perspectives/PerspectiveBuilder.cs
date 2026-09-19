namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for 3D perspective, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("perspective-", Responsive = true)]
public sealed class PerspectiveBuilder : FinalClassUtilityBuilder<PerspectiveBuilder>
{
    internal PerspectiveBuilder()
    {
    }

    internal PerspectiveBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>perspective-none</c>.</summary>
    public PerspectiveBuilder None => ChainClass("perspective-none");

    /// <summary>Adds <c>perspective-dramatic</c>.</summary>
    public PerspectiveBuilder Dramatic => ChainClass("perspective-dramatic");

    /// <summary>Adds <c>perspective-near</c>.</summary>
    public PerspectiveBuilder Near => ChainClass("perspective-near");

    /// <summary>Adds <c>perspective-normal</c>.</summary>
    public PerspectiveBuilder Normal => ChainClass("perspective-normal");

    /// <summary>Adds <c>perspective-midrange</c>.</summary>
    public PerspectiveBuilder Midrange => ChainClass("perspective-midrange");

    /// <summary>Adds <c>perspective-distant</c>.</summary>
    public PerspectiveBuilder Distant => ChainClass("perspective-distant");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public PerspectiveBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "perspective-"));
}
