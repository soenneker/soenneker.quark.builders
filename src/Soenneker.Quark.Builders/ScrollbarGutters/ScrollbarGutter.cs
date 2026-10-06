namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for reserved scrollbar space.
/// </summary>
[TailwindModifiers(typeof(ScrollbarGutterBuilder))]
public static partial class ScrollbarGutter
{
    /// <summary>Adds <c>scrollbar-gutter-auto</c>.</summary>
    public static ScrollbarGutterBuilder Auto => new("scrollbar-gutter-auto");

    /// <summary>Adds <c>scrollbar-gutter-stable</c>.</summary>
    public static ScrollbarGutterBuilder Stable => new("scrollbar-gutter-stable");

    /// <summary>Adds <c>scrollbar-gutter-both</c>.</summary>
    public static ScrollbarGutterBuilder Both => new("scrollbar-gutter-both");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ScrollbarGutterBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "scrollbar-gutter-"));
}
