namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for inset box shadows.
/// </summary>
[TailwindModifiers(typeof(InsetShadowBuilder))]
public static partial class InsetShadow
{
    /// <summary>Adds <c>inset-shadow-none</c>.</summary>
    public static InsetShadowBuilder None => new("inset-shadow-none");

    /// <summary>Adds <c>inset-shadow-2xs</c>.</summary>
    public static InsetShadowBuilder TwoXs => new("inset-shadow-2xs");

    /// <summary>Adds <c>inset-shadow-xs</c>.</summary>
    public static InsetShadowBuilder Xs => new("inset-shadow-xs");

    /// <summary>Adds <c>inset-shadow-sm</c>.</summary>
    public static InsetShadowBuilder Sm => new("inset-shadow-sm");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static InsetShadowBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "inset-shadow-"));
}
