namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for complete backdrop filter expressions, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-filter-", Responsive = true)]
public sealed class BackdropFilterBuilder : FinalClassUtilityBuilder<BackdropFilterBuilder>
{
    internal BackdropFilterBuilder()
    {
    }

    internal BackdropFilterBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-filter-none</c>.</summary>
    public BackdropFilterBuilder None => ChainClass("backdrop-filter-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropFilterBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-filter-"));
}
