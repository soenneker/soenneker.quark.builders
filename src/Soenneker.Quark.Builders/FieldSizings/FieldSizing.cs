namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for form field sizing.
/// </summary>
[TailwindModifiers(typeof(FieldSizingBuilder))]
public static partial class FieldSizing
{
    /// <summary>Adds <c>field-sizing-content</c>.</summary>
    public static FieldSizingBuilder Content => new("field-sizing-content");

    /// <summary>Adds <c>field-sizing-fixed</c>.</summary>
    public static FieldSizingBuilder Fixed => new("field-sizing-fixed");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static FieldSizingBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "field-sizing-"));
}
