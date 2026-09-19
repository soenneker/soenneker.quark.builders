namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for 3D transform rendering, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("transform-", Responsive = true)]
public sealed class TransformStyleBuilder : FinalClassUtilityBuilder<TransformStyleBuilder>
{
    internal TransformStyleBuilder()
    {
    }

    internal TransformStyleBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>transform-flat</c>.</summary>
    public TransformStyleBuilder Flat => ChainClass("transform-flat");

    /// <summary>Adds <c>transform-3d</c>.</summary>
    public TransformStyleBuilder Preserve3D => ChainClass("transform-3d");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public TransformStyleBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "transform-"));
}
