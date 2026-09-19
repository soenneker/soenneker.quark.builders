namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for complete filter expressions, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("filter-", Responsive = true)]
public sealed class FilterBuilder : FinalClassUtilityBuilder<FilterBuilder>
{
    internal FilterBuilder()
    {
    }

    internal FilterBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>filter-none</c>.</summary>
    public FilterBuilder None => ChainClass("filter-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public FilterBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "filter-"));
}
