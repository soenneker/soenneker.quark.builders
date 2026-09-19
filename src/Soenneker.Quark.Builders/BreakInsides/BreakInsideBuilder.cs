namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for breaks inside an element, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("break-inside-", Responsive = true)]
public sealed class BreakInsideBuilder : FinalClassUtilityBuilder<BreakInsideBuilder>
{
    internal BreakInsideBuilder()
    {
    }

    internal BreakInsideBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>break-inside-auto</c>.</summary>
    public BreakInsideBuilder Auto => ChainClass("break-inside-auto");

    /// <summary>Adds <c>break-inside-avoid</c>.</summary>
    public BreakInsideBuilder Avoid => ChainClass("break-inside-avoid");

    /// <summary>Adds <c>break-inside-avoid-page</c>.</summary>
    public BreakInsideBuilder AvoidPage => ChainClass("break-inside-avoid-page");

    /// <summary>Adds <c>break-inside-avoid-column</c>.</summary>
    public BreakInsideBuilder AvoidColumn => ChainClass("break-inside-avoid-column");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BreakInsideBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "break-inside-"));
}
