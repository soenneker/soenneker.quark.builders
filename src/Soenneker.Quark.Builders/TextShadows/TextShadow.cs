namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for text shadows.
/// </summary>
[TailwindModifiers(typeof(TextShadowBuilder))]
public static partial class TextShadow
{
    /// <summary>Adds <c>text-shadow-none</c>.</summary>
    public static TextShadowBuilder None => new("text-shadow-none");

    /// <summary>Adds <c>text-shadow-2xs</c>.</summary>
    public static TextShadowBuilder TwoXs => new("text-shadow-2xs");

    /// <summary>Adds <c>text-shadow-xs</c>.</summary>
    public static TextShadowBuilder Xs => new("text-shadow-xs");

    /// <summary>Adds <c>text-shadow-sm</c>.</summary>
    public static TextShadowBuilder Sm => new("text-shadow-sm");

    /// <summary>Adds <c>text-shadow-md</c>.</summary>
    public static TextShadowBuilder Md => new("text-shadow-md");

    /// <summary>Adds <c>text-shadow-lg</c>.</summary>
    public static TextShadowBuilder Lg => new("text-shadow-lg");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static TextShadowBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "text-shadow-"));
}
