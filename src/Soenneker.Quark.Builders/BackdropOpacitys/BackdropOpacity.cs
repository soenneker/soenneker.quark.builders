namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop filter opacity.
/// </summary>
[TailwindModifiers(typeof(BackdropOpacityBuilder))]
public static partial class BackdropOpacity
{
    /// <summary>Adds <c>backdrop-opacity-0</c>.</summary>
    public static BackdropOpacityBuilder Is0 => new("backdrop-opacity-0");

    /// <summary>Adds <c>backdrop-opacity-5</c>.</summary>
    public static BackdropOpacityBuilder Is5 => new("backdrop-opacity-5");

    /// <summary>Adds <c>backdrop-opacity-10</c>.</summary>
    public static BackdropOpacityBuilder Is10 => new("backdrop-opacity-10");

    /// <summary>Adds <c>backdrop-opacity-20</c>.</summary>
    public static BackdropOpacityBuilder Is20 => new("backdrop-opacity-20");

    /// <summary>Adds <c>backdrop-opacity-25</c>.</summary>
    public static BackdropOpacityBuilder Is25 => new("backdrop-opacity-25");

    /// <summary>Adds <c>backdrop-opacity-30</c>.</summary>
    public static BackdropOpacityBuilder Is30 => new("backdrop-opacity-30");

    /// <summary>Adds <c>backdrop-opacity-40</c>.</summary>
    public static BackdropOpacityBuilder Is40 => new("backdrop-opacity-40");

    /// <summary>Adds <c>backdrop-opacity-50</c>.</summary>
    public static BackdropOpacityBuilder Is50 => new("backdrop-opacity-50");

    /// <summary>Adds <c>backdrop-opacity-60</c>.</summary>
    public static BackdropOpacityBuilder Is60 => new("backdrop-opacity-60");

    /// <summary>Adds <c>backdrop-opacity-70</c>.</summary>
    public static BackdropOpacityBuilder Is70 => new("backdrop-opacity-70");

    /// <summary>Adds <c>backdrop-opacity-75</c>.</summary>
    public static BackdropOpacityBuilder Is75 => new("backdrop-opacity-75");

    /// <summary>Adds <c>backdrop-opacity-80</c>.</summary>
    public static BackdropOpacityBuilder Is80 => new("backdrop-opacity-80");

    /// <summary>Adds <c>backdrop-opacity-90</c>.</summary>
    public static BackdropOpacityBuilder Is90 => new("backdrop-opacity-90");

    /// <summary>Adds <c>backdrop-opacity-95</c>.</summary>
    public static BackdropOpacityBuilder Is95 => new("backdrop-opacity-95");

    /// <summary>Adds <c>backdrop-opacity-100</c>.</summary>
    public static BackdropOpacityBuilder Is100 => new("backdrop-opacity-100");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropOpacityBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-opacity-"));
}
