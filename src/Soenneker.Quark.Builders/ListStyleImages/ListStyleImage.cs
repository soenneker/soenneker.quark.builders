namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for list marker images.
/// </summary>
[TailwindModifiers(typeof(ListStyleImageBuilder))]
public static partial class ListStyleImage
{
    /// <summary>Adds <c>list-image-none</c>.</summary>
    public static ListStyleImageBuilder None => new("list-image-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ListStyleImageBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "list-image-"));
}
