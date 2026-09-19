namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backface visibility.
/// </summary>
[TailwindModifiers(typeof(BackfaceVisibilityBuilder))]
public static partial class BackfaceVisibility
{
    /// <summary>Adds <c>backface-visible</c>.</summary>
    public static BackfaceVisibilityBuilder Visible => new("backface-visible");

    /// <summary>Adds <c>backface-hidden</c>.</summary>
    public static BackfaceVisibilityBuilder Hidden => new("backface-hidden");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackfaceVisibilityBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backface-"));
}
