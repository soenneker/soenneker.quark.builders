namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for fragmentation breaks, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("break-before-", Responsive = true)]
public sealed class BreakBeforeBuilder : FinalClassUtilityBuilder<BreakBeforeBuilder>
{
    internal BreakBeforeBuilder()
    {
    }

    internal BreakBeforeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>break-before-auto</c>.</summary>
    public BreakBeforeBuilder Auto => ChainClass("break-before-auto");

    /// <summary>Adds <c>break-before-avoid</c>.</summary>
    public BreakBeforeBuilder Avoid => ChainClass("break-before-avoid");

    /// <summary>Adds <c>break-before-all</c>.</summary>
    public BreakBeforeBuilder All => ChainClass("break-before-all");

    /// <summary>Adds <c>break-before-avoid-page</c>.</summary>
    public BreakBeforeBuilder AvoidPage => ChainClass("break-before-avoid-page");

    /// <summary>Adds <c>break-before-page</c>.</summary>
    public BreakBeforeBuilder Page => ChainClass("break-before-page");

    /// <summary>Adds <c>break-before-left</c>.</summary>
    public BreakBeforeBuilder Left => ChainClass("break-before-left");

    /// <summary>Adds <c>break-before-right</c>.</summary>
    public BreakBeforeBuilder Right => ChainClass("break-before-right");

    /// <summary>Adds <c>break-before-column</c>.</summary>
    public BreakBeforeBuilder Column => ChainClass("break-before-column");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BreakBeforeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "break-before-"));
}
