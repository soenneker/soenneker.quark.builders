namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for list marker positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("list-", Responsive = true)]
public sealed class ListStylePositionBuilder : FinalClassUtilityBuilder<ListStylePositionBuilder>
{
    internal ListStylePositionBuilder()
    {
    }

    internal ListStylePositionBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>list-inside</c>.</summary>
    public ListStylePositionBuilder Inside => ChainClass("list-inside");

    /// <summary>Adds <c>list-outside</c>.</summary>
    public ListStylePositionBuilder Outside => ChainClass("list-outside");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ListStylePositionBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "list-"));
}
