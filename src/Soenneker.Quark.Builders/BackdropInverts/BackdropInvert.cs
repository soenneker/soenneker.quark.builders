namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop invert filters.
/// </summary>
[TailwindModifiers(typeof(BackdropInvertBuilder))]
public static partial class BackdropInvert
{
    /// <summary>Adds <c>backdrop-invert-0</c>.</summary>
    public static BackdropInvertBuilder Is0 => new("backdrop-invert-0");

    /// <summary>Adds <c>backdrop-invert-25</c>.</summary>
    public static BackdropInvertBuilder Is25 => new("backdrop-invert-25");

    /// <summary>Adds <c>backdrop-invert-50</c>.</summary>
    public static BackdropInvertBuilder Is50 => new("backdrop-invert-50");

    /// <summary>Adds <c>backdrop-invert-75</c>.</summary>
    public static BackdropInvertBuilder Is75 => new("backdrop-invert-75");

    /// <summary>Adds <c>backdrop-invert-100</c>.</summary>
    public static BackdropInvertBuilder Is100 => new("backdrop-invert-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropInvertBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-invert-"));
}
