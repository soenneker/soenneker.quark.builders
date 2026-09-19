namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for decoration across fragmented boxes, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("box-decoration-", Responsive = true)]
public sealed class BoxDecorationBreakBuilder : FinalClassUtilityBuilder<BoxDecorationBreakBuilder>
{
    internal BoxDecorationBreakBuilder()
    {
    }

    internal BoxDecorationBreakBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>box-decoration-clone</c>.</summary>
    public BoxDecorationBreakBuilder Clone => ChainClass("box-decoration-clone");

    /// <summary>Adds <c>box-decoration-slice</c>.</summary>
    public BoxDecorationBreakBuilder Slice => ChainClass("box-decoration-slice");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BoxDecorationBreakBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "box-decoration-"));
}
