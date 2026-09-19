namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for scrollbar width, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("scrollbar-", Responsive = true)]
public sealed class ScrollbarWidthBuilder : FinalClassUtilityBuilder<ScrollbarWidthBuilder>
{
    internal ScrollbarWidthBuilder()
    {
    }

    internal ScrollbarWidthBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>scrollbar-auto</c>.</summary>
    public ScrollbarWidthBuilder Auto => ChainClass("scrollbar-auto");

    /// <summary>Adds <c>scrollbar-thin</c>.</summary>
    public ScrollbarWidthBuilder Thin => ChainClass("scrollbar-thin");

    /// <summary>Adds <c>scrollbar-none</c>.</summary>
    public ScrollbarWidthBuilder None => ChainClass("scrollbar-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ScrollbarWidthBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "scrollbar-"));
}
