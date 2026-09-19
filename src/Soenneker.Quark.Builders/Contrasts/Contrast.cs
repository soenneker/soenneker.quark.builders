namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for contrast filters.
/// </summary>
[TailwindModifiers(typeof(ContrastBuilder))]
public static partial class Contrast
{
    /// <summary>Adds <c>contrast-0</c>.</summary>
    public static ContrastBuilder Is0 => new("contrast-0");

    /// <summary>Adds <c>contrast-50</c>.</summary>
    public static ContrastBuilder Is50 => new("contrast-50");

    /// <summary>Adds <c>contrast-75</c>.</summary>
    public static ContrastBuilder Is75 => new("contrast-75");

    /// <summary>Adds <c>contrast-100</c>.</summary>
    public static ContrastBuilder Is100 => new("contrast-100");

    /// <summary>Adds <c>contrast-125</c>.</summary>
    public static ContrastBuilder Is125 => new("contrast-125");

    /// <summary>Adds <c>contrast-150</c>.</summary>
    public static ContrastBuilder Is150 => new("contrast-150");

    /// <summary>Adds <c>contrast-200</c>.</summary>
    public static ContrastBuilder Is200 => new("contrast-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ContrastBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "contrast-"));
}
