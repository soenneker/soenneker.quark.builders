namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for fragmentation breaks.
/// </summary>
[TailwindModifiers(typeof(BreakBeforeBuilder))]
public static partial class BreakBefore
{
    /// <summary>Adds <c>break-before-auto</c>.</summary>
    public static BreakBeforeBuilder Auto => new("break-before-auto");

    /// <summary>Adds <c>break-before-avoid</c>.</summary>
    public static BreakBeforeBuilder Avoid => new("break-before-avoid");

    /// <summary>Adds <c>break-before-all</c>.</summary>
    public static BreakBeforeBuilder All => new("break-before-all");

    /// <summary>Adds <c>break-before-avoid-page</c>.</summary>
    public static BreakBeforeBuilder AvoidPage => new("break-before-avoid-page");

    /// <summary>Adds <c>break-before-page</c>.</summary>
    public static BreakBeforeBuilder Page => new("break-before-page");

    /// <summary>Adds <c>break-before-left</c>.</summary>
    public static BreakBeforeBuilder Left => new("break-before-left");

    /// <summary>Adds <c>break-before-right</c>.</summary>
    public static BreakBeforeBuilder Right => new("break-before-right");

    /// <summary>Adds <c>break-before-column</c>.</summary>
    public static BreakBeforeBuilder Column => new("break-before-column");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BreakBeforeBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "break-before-"));
}
