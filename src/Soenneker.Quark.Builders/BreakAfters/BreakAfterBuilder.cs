namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for fragmentation breaks, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("break-after-", Responsive = true)]
public sealed class BreakAfterBuilder : FinalClassUtilityBuilder<BreakAfterBuilder>
{
    internal BreakAfterBuilder()
    {
    }

    internal BreakAfterBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>break-after-auto</c>.</summary>
    public BreakAfterBuilder Auto => ChainClass("break-after-auto");

    /// <summary>Adds <c>break-after-avoid</c>.</summary>
    public BreakAfterBuilder Avoid => ChainClass("break-after-avoid");

    /// <summary>Adds <c>break-after-all</c>.</summary>
    public BreakAfterBuilder All => ChainClass("break-after-all");

    /// <summary>Adds <c>break-after-avoid-page</c>.</summary>
    public BreakAfterBuilder AvoidPage => ChainClass("break-after-avoid-page");

    /// <summary>Adds <c>break-after-page</c>.</summary>
    public BreakAfterBuilder Page => ChainClass("break-after-page");

    /// <summary>Adds <c>break-after-left</c>.</summary>
    public BreakAfterBuilder Left => ChainClass("break-after-left");

    /// <summary>Adds <c>break-after-right</c>.</summary>
    public BreakAfterBuilder Right => ChainClass("break-after-right");

    /// <summary>Adds <c>break-after-column</c>.</summary>
    public BreakAfterBuilder Column => ChainClass("break-after-column");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BreakAfterBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "break-after-"));
}
