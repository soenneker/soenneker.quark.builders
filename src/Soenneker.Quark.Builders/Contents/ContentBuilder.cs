namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for generated content in pseudo-elements, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("content-", Responsive = true)]
public sealed class ContentBuilder : FinalClassUtilityBuilder<ContentBuilder>
{
    internal ContentBuilder()
    {
    }

    internal ContentBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>content-none</c>.</summary>
    public ContentBuilder None => ChainClass("content-none");

    /// <summary>Adds <c>content-['']</c>.</summary>
    public ContentBuilder Empty => ChainClass("content-['']");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ContentBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "content-"));
}
