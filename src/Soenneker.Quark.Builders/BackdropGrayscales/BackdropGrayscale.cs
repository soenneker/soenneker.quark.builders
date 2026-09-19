namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop grayscale filters.
/// </summary>
[TailwindModifiers(typeof(BackdropGrayscaleBuilder))]
public static partial class BackdropGrayscale
{
    /// <summary>Adds <c>backdrop-grayscale-0</c>.</summary>
    public static BackdropGrayscaleBuilder Is0 => new("backdrop-grayscale-0");

    /// <summary>Adds <c>backdrop-grayscale-25</c>.</summary>
    public static BackdropGrayscaleBuilder Is25 => new("backdrop-grayscale-25");

    /// <summary>Adds <c>backdrop-grayscale-50</c>.</summary>
    public static BackdropGrayscaleBuilder Is50 => new("backdrop-grayscale-50");

    /// <summary>Adds <c>backdrop-grayscale-75</c>.</summary>
    public static BackdropGrayscaleBuilder Is75 => new("backdrop-grayscale-75");

    /// <summary>Adds <c>backdrop-grayscale-100</c>.</summary>
    public static BackdropGrayscaleBuilder Is100 => new("backdrop-grayscale-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropGrayscaleBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-grayscale-"));
}
