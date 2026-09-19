namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for generated content in pseudo-elements.
/// </summary>
[TailwindModifiers(typeof(ContentBuilder))]
public static partial class Content
{
    /// <summary>Adds <c>content-none</c>.</summary>
    public static ContentBuilder None => new("content-none");

    /// <summary>Adds <c>content-['']</c>.</summary>
    public static ContentBuilder Empty => new("content-['']");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ContentBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "content-"));
}
