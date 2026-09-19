namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for breaks inside an element.
/// </summary>
[TailwindModifiers(typeof(BreakInsideBuilder))]
public static partial class BreakInside
{
    /// <summary>Adds <c>break-inside-auto</c>.</summary>
    public static BreakInsideBuilder Auto => new("break-inside-auto");

    /// <summary>Adds <c>break-inside-avoid</c>.</summary>
    public static BreakInsideBuilder Avoid => new("break-inside-avoid");

    /// <summary>Adds <c>break-inside-avoid-page</c>.</summary>
    public static BreakInsideBuilder AvoidPage => new("break-inside-avoid-page");

    /// <summary>Adds <c>break-inside-avoid-column</c>.</summary>
    public static BreakInsideBuilder AvoidColumn => new("break-inside-avoid-column");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BreakInsideBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "break-inside-"));
}
