namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop sepia filters.
/// </summary>
[TailwindModifiers(typeof(BackdropSepiaBuilder))]
public static partial class BackdropSepia
{
    /// <summary>Adds <c>backdrop-sepia-0</c>.</summary>
    public static BackdropSepiaBuilder Is0 => new("backdrop-sepia-0");

    /// <summary>Adds <c>backdrop-sepia-25</c>.</summary>
    public static BackdropSepiaBuilder Is25 => new("backdrop-sepia-25");

    /// <summary>Adds <c>backdrop-sepia-50</c>.</summary>
    public static BackdropSepiaBuilder Is50 => new("backdrop-sepia-50");

    /// <summary>Adds <c>backdrop-sepia-75</c>.</summary>
    public static BackdropSepiaBuilder Is75 => new("backdrop-sepia-75");

    /// <summary>Adds <c>backdrop-sepia-100</c>.</summary>
    public static BackdropSepiaBuilder Is100 => new("backdrop-sepia-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropSepiaBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-sepia-"));
}
