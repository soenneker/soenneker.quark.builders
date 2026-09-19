namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for drop shadow filters.
/// </summary>
[TailwindModifiers(typeof(DropShadowBuilder))]
public static partial class DropShadow
{
    /// <summary>Adds <c>drop-shadow-none</c>.</summary>
    public static DropShadowBuilder None => new("drop-shadow-none");

    /// <summary>Adds <c>drop-shadow-xs</c>.</summary>
    public static DropShadowBuilder Xs => new("drop-shadow-xs");

    /// <summary>Adds <c>drop-shadow-sm</c>.</summary>
    public static DropShadowBuilder Sm => new("drop-shadow-sm");

    /// <summary>Adds <c>drop-shadow-md</c>.</summary>
    public static DropShadowBuilder Md => new("drop-shadow-md");

    /// <summary>Adds <c>drop-shadow-lg</c>.</summary>
    public static DropShadowBuilder Lg => new("drop-shadow-lg");

    /// <summary>Adds <c>drop-shadow-xl</c>.</summary>
    public static DropShadowBuilder Xl => new("drop-shadow-xl");

    /// <summary>Adds <c>drop-shadow-2xl</c>.</summary>
    public static DropShadowBuilder TwoXl => new("drop-shadow-2xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static DropShadowBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "drop-shadow-"));
}
