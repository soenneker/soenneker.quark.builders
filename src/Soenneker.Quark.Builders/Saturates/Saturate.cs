namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for saturate filters.
/// </summary>
[TailwindModifiers(typeof(SaturateBuilder))]
public static partial class Saturate
{
    /// <summary>Adds <c>saturate-0</c>.</summary>
    public static SaturateBuilder Is0 => new("saturate-0");

    /// <summary>Adds <c>saturate-50</c>.</summary>
    public static SaturateBuilder Is50 => new("saturate-50");

    /// <summary>Adds <c>saturate-100</c>.</summary>
    public static SaturateBuilder Is100 => new("saturate-100");

    /// <summary>Adds <c>saturate-150</c>.</summary>
    public static SaturateBuilder Is150 => new("saturate-150");

    /// <summary>Adds <c>saturate-200</c>.</summary>
    public static SaturateBuilder Is200 => new("saturate-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static SaturateBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "saturate-"));
}
