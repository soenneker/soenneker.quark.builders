namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for grayscale filters.
/// </summary>
[TailwindModifiers(typeof(GrayscaleBuilder))]
public static partial class Grayscale
{
    /// <summary>Adds <c>grayscale-0</c>.</summary>
    public static GrayscaleBuilder Is0 => new("grayscale-0");

    /// <summary>Adds <c>grayscale-25</c>.</summary>
    public static GrayscaleBuilder Is25 => new("grayscale-25");

    /// <summary>Adds <c>grayscale-50</c>.</summary>
    public static GrayscaleBuilder Is50 => new("grayscale-50");

    /// <summary>Adds <c>grayscale-75</c>.</summary>
    public static GrayscaleBuilder Is75 => new("grayscale-75");

    /// <summary>Adds <c>grayscale-100</c>.</summary>
    public static GrayscaleBuilder Is100 => new("grayscale-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static GrayscaleBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "grayscale-"));
}
