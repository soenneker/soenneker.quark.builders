namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for scrollbar width.
/// </summary>
[TailwindModifiers(typeof(ScrollbarWidthBuilder))]
public static partial class ScrollbarWidth
{
    /// <summary>Adds <c>scrollbar-auto</c>.</summary>
    public static ScrollbarWidthBuilder Auto => new("scrollbar-auto");

    /// <summary>Adds <c>scrollbar-thin</c>.</summary>
    public static ScrollbarWidthBuilder Thin => new("scrollbar-thin");

    /// <summary>Adds <c>scrollbar-none</c>.</summary>
    public static ScrollbarWidthBuilder None => new("scrollbar-none");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ScrollbarWidthBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "scrollbar-"));
}
