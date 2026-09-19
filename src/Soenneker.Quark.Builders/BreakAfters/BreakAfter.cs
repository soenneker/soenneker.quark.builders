namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for fragmentation breaks.
/// </summary>
[TailwindModifiers(typeof(BreakAfterBuilder))]
public static partial class BreakAfter
{
    /// <summary>Adds <c>break-after-auto</c>.</summary>
    public static BreakAfterBuilder Auto => new("break-after-auto");

    /// <summary>Adds <c>break-after-avoid</c>.</summary>
    public static BreakAfterBuilder Avoid => new("break-after-avoid");

    /// <summary>Adds <c>break-after-all</c>.</summary>
    public static BreakAfterBuilder All => new("break-after-all");

    /// <summary>Adds <c>break-after-avoid-page</c>.</summary>
    public static BreakAfterBuilder AvoidPage => new("break-after-avoid-page");

    /// <summary>Adds <c>break-after-page</c>.</summary>
    public static BreakAfterBuilder Page => new("break-after-page");

    /// <summary>Adds <c>break-after-left</c>.</summary>
    public static BreakAfterBuilder Left => new("break-after-left");

    /// <summary>Adds <c>break-after-right</c>.</summary>
    public static BreakAfterBuilder Right => new("break-after-right");

    /// <summary>Adds <c>break-after-column</c>.</summary>
    public static BreakAfterBuilder Column => new("break-after-column");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BreakAfterBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "break-after-"));
}
