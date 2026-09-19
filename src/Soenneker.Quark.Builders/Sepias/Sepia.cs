namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for sepia filters.
/// </summary>
[TailwindModifiers(typeof(SepiaBuilder))]
public static partial class Sepia
{
    /// <summary>Adds <c>sepia-0</c>.</summary>
    public static SepiaBuilder Is0 => new("sepia-0");

    /// <summary>Adds <c>sepia-25</c>.</summary>
    public static SepiaBuilder Is25 => new("sepia-25");

    /// <summary>Adds <c>sepia-50</c>.</summary>
    public static SepiaBuilder Is50 => new("sepia-50");

    /// <summary>Adds <c>sepia-75</c>.</summary>
    public static SepiaBuilder Is75 => new("sepia-75");

    /// <summary>Adds <c>sepia-100</c>.</summary>
    public static SepiaBuilder Is100 => new("sepia-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static SepiaBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "sepia-"));
}
