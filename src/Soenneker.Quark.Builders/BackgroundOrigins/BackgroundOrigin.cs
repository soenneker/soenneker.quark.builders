namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for background positioning origins.
/// </summary>
[TailwindModifiers(typeof(BackgroundOriginBuilder))]
public static partial class BackgroundOrigin
{
    /// <summary>Adds <c>bg-origin-border</c>.</summary>
    public static BackgroundOriginBuilder Border => new("bg-origin-border");

    /// <summary>Adds <c>bg-origin-padding</c>.</summary>
    public static BackgroundOriginBuilder Padding => new("bg-origin-padding");

    /// <summary>Adds <c>bg-origin-content</c>.</summary>
    public static BackgroundOriginBuilder Content => new("bg-origin-content");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackgroundOriginBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "bg-origin-"));
}
