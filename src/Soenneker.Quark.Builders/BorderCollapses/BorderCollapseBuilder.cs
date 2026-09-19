namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for table border collapsing, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderCollapseBuilder : FinalClassUtilityBuilder<BorderCollapseBuilder>
{
    internal BorderCollapseBuilder()
    {
    }

    internal BorderCollapseBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>border-collapse</c>.</summary>
    public BorderCollapseBuilder Collapse => ChainClass("border-collapse");

    /// <summary>Adds <c>border-separate</c>.</summary>
    public BorderCollapseBuilder Separate => ChainClass("border-separate");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BorderCollapseBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "border-"));
}
