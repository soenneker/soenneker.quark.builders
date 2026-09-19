namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for invert filters.
/// </summary>
[TailwindModifiers(typeof(InvertBuilder))]
public static partial class Invert
{
    /// <summary>Adds <c>invert-0</c>.</summary>
    public static InvertBuilder Is0 => new("invert-0");

    /// <summary>Adds <c>invert-25</c>.</summary>
    public static InvertBuilder Is25 => new("invert-25");

    /// <summary>Adds <c>invert-50</c>.</summary>
    public static InvertBuilder Is50 => new("invert-50");

    /// <summary>Adds <c>invert-75</c>.</summary>
    public static InvertBuilder Is75 => new("invert-75");

    /// <summary>Adds <c>invert-100</c>.</summary>
    public static InvertBuilder Is100 => new("invert-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InvertBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "invert-"));
}
