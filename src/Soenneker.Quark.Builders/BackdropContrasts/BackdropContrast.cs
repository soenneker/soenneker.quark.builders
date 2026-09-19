namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop contrast filters.
/// </summary>
[TailwindModifiers(typeof(BackdropContrastBuilder))]
public static partial class BackdropContrast
{
    /// <summary>Adds <c>backdrop-contrast-0</c>.</summary>
    public static BackdropContrastBuilder Is0 => new("backdrop-contrast-0");

    /// <summary>Adds <c>backdrop-contrast-50</c>.</summary>
    public static BackdropContrastBuilder Is50 => new("backdrop-contrast-50");

    /// <summary>Adds <c>backdrop-contrast-75</c>.</summary>
    public static BackdropContrastBuilder Is75 => new("backdrop-contrast-75");

    /// <summary>Adds <c>backdrop-contrast-100</c>.</summary>
    public static BackdropContrastBuilder Is100 => new("backdrop-contrast-100");

    /// <summary>Adds <c>backdrop-contrast-125</c>.</summary>
    public static BackdropContrastBuilder Is125 => new("backdrop-contrast-125");

    /// <summary>Adds <c>backdrop-contrast-150</c>.</summary>
    public static BackdropContrastBuilder Is150 => new("backdrop-contrast-150");

    /// <summary>Adds <c>backdrop-contrast-200</c>.</summary>
    public static BackdropContrastBuilder Is200 => new("backdrop-contrast-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropContrastBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-contrast-"));
}
