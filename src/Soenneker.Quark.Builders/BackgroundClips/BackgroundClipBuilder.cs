namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for background clipping, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("bg-clip-", Responsive = true)]
public sealed class BackgroundClipBuilder : FinalClassUtilityBuilder<BackgroundClipBuilder>
{
    internal BackgroundClipBuilder()
    {
    }

    internal BackgroundClipBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>bg-clip-border</c>.</summary>
    public BackgroundClipBuilder Border => ChainClass("bg-clip-border");

    /// <summary>Adds <c>bg-clip-padding</c>.</summary>
    public BackgroundClipBuilder Padding => ChainClass("bg-clip-padding");

    /// <summary>Adds <c>bg-clip-content</c>.</summary>
    public BackgroundClipBuilder Content => ChainClass("bg-clip-content");

    /// <summary>Adds <c>bg-clip-text</c>.</summary>
    public BackgroundClipBuilder Text => ChainClass("bg-clip-text");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackgroundClipBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "bg-clip-"));
}
