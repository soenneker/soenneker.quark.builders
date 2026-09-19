namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for blur filters.
/// </summary>
[TailwindModifiers(typeof(BlurBuilder))]
public static partial class Blur
{
    /// <summary>Adds <c>blur-none</c>.</summary>
    public static BlurBuilder None => new("blur-none");

    /// <summary>Adds <c>blur-xs</c>.</summary>
    public static BlurBuilder Xs => new("blur-xs");

    /// <summary>Adds <c>blur-sm</c>.</summary>
    public static BlurBuilder Sm => new("blur-sm");

    /// <summary>Adds <c>blur-md</c>.</summary>
    public static BlurBuilder Md => new("blur-md");

    /// <summary>Adds <c>blur-lg</c>.</summary>
    public static BlurBuilder Lg => new("blur-lg");

    /// <summary>Adds <c>blur-xl</c>.</summary>
    public static BlurBuilder Xl => new("blur-xl");

    /// <summary>Adds <c>blur-2xl</c>.</summary>
    public static BlurBuilder TwoXl => new("blur-2xl");

    /// <summary>Adds <c>blur-3xl</c>.</summary>
    public static BlurBuilder ThreeXl => new("blur-3xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BlurBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "blur-"));
}
