namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop saturate filters.
/// </summary>
[TailwindModifiers(typeof(BackdropSaturateBuilder))]
public static partial class BackdropSaturate
{
    /// <summary>Adds <c>backdrop-saturate-0</c>.</summary>
    public static BackdropSaturateBuilder Is0 => new("backdrop-saturate-0");

    /// <summary>Adds <c>backdrop-saturate-50</c>.</summary>
    public static BackdropSaturateBuilder Is50 => new("backdrop-saturate-50");

    /// <summary>Adds <c>backdrop-saturate-100</c>.</summary>
    public static BackdropSaturateBuilder Is100 => new("backdrop-saturate-100");

    /// <summary>Adds <c>backdrop-saturate-150</c>.</summary>
    public static BackdropSaturateBuilder Is150 => new("backdrop-saturate-150");

    /// <summary>Adds <c>backdrop-saturate-200</c>.</summary>
    public static BackdropSaturateBuilder Is200 => new("backdrop-saturate-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropSaturateBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-saturate-"));
}
