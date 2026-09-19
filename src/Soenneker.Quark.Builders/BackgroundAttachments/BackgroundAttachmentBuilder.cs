namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for background attachment, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundAttachmentBuilder : FinalClassUtilityBuilder<BackgroundAttachmentBuilder>
{
    internal BackgroundAttachmentBuilder()
    {
    }

    internal BackgroundAttachmentBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>bg-fixed</c>.</summary>
    public BackgroundAttachmentBuilder Fixed => ChainClass("bg-fixed");

    /// <summary>Adds <c>bg-local</c>.</summary>
    public BackgroundAttachmentBuilder Local => ChainClass("bg-local");

    /// <summary>Adds <c>bg-scroll</c>.</summary>
    public BackgroundAttachmentBuilder Scroll => ChainClass("bg-scroll");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackgroundAttachmentBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "bg-"));
}
