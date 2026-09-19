namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for form field sizing, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("field-sizing-", Responsive = true)]
public sealed class FieldSizingBuilder : FinalClassUtilityBuilder<FieldSizingBuilder>
{
    internal FieldSizingBuilder()
    {
    }

    internal FieldSizingBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>field-sizing-content</c>.</summary>
    public FieldSizingBuilder Content => ChainClass("field-sizing-content");

    /// <summary>Adds <c>field-sizing-fixed</c>.</summary>
    public FieldSizingBuilder Fixed => ChainClass("field-sizing-fixed");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public FieldSizingBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "field-sizing-"));
}
