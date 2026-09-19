namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for list marker images, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("list-image-", Responsive = true)]
public sealed class ListStyleImageBuilder : FinalClassUtilityBuilder<ListStyleImageBuilder>
{
    internal ListStyleImageBuilder()
    {
    }

    internal ListStyleImageBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>list-image-none</c>.</summary>
    public ListStyleImageBuilder None => ChainClass("list-image-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ListStyleImageBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "list-image-"));
}
