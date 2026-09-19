namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for background clipping.
/// </summary>
[TailwindModifiers(typeof(BackgroundClipBuilder))]
public static partial class BackgroundClip
{
    /// <summary>Adds <c>bg-clip-border</c>.</summary>
    public static BackgroundClipBuilder Border => new("bg-clip-border");

    /// <summary>Adds <c>bg-clip-padding</c>.</summary>
    public static BackgroundClipBuilder Padding => new("bg-clip-padding");

    /// <summary>Adds <c>bg-clip-content</c>.</summary>
    public static BackgroundClipBuilder Content => new("bg-clip-content");

    /// <summary>Adds <c>bg-clip-text</c>.</summary>
    public static BackgroundClipBuilder Text => new("bg-clip-text");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackgroundClipBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "bg-clip-"));
}
