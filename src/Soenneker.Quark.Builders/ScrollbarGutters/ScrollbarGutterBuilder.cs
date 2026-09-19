namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for reserved scrollbar space, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("scrollbar-gutter-", Responsive = true)]
public sealed class ScrollbarGutterBuilder : FinalClassUtilityBuilder<ScrollbarGutterBuilder>
{
    internal ScrollbarGutterBuilder()
    {
    }

    internal ScrollbarGutterBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>scrollbar-gutter-auto</c>.</summary>
    public ScrollbarGutterBuilder Auto => ChainClass("scrollbar-gutter-auto");

    /// <summary>Adds <c>scrollbar-gutter-stable</c>.</summary>
    public ScrollbarGutterBuilder Stable => ChainClass("scrollbar-gutter-stable");

    /// <summary>Adds <c>scrollbar-gutter-both</c>.</summary>
    public ScrollbarGutterBuilder Both => ChainClass("scrollbar-gutter-both");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ScrollbarGutterBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "scrollbar-gutter-"));
}
