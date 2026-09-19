namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for table caption positioning, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("caption-", Responsive = true)]
public sealed class CaptionSideBuilder : FinalClassUtilityBuilder<CaptionSideBuilder>
{
    internal CaptionSideBuilder()
    {
    }

    internal CaptionSideBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>caption-top</c>.</summary>
    public CaptionSideBuilder Top => ChainClass("caption-top");

    /// <summary>Adds <c>caption-bottom</c>.</summary>
    public CaptionSideBuilder Bottom => ChainClass("caption-bottom");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public CaptionSideBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "caption-"));
}
