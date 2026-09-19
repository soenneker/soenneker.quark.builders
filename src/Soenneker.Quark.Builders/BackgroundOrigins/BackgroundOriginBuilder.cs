namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for background positioning origins, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("bg-origin-", Responsive = true)]
public sealed class BackgroundOriginBuilder : FinalClassUtilityBuilder<BackgroundOriginBuilder>
{
    internal BackgroundOriginBuilder()
    {
    }

    internal BackgroundOriginBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>bg-origin-border</c>.</summary>
    public BackgroundOriginBuilder Border => ChainClass("bg-origin-border");

    /// <summary>Adds <c>bg-origin-padding</c>.</summary>
    public BackgroundOriginBuilder Padding => ChainClass("bg-origin-padding");

    /// <summary>Adds <c>bg-origin-content</c>.</summary>
    public BackgroundOriginBuilder Content => ChainClass("bg-origin-content");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackgroundOriginBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "bg-origin-"));
}
