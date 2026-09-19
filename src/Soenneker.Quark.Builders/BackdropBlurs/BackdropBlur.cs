namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop blur filters.
/// </summary>
[TailwindModifiers(typeof(BackdropBlurBuilder))]
public static partial class BackdropBlur
{
    /// <summary>Adds <c>backdrop-blur-none</c>.</summary>
    public static BackdropBlurBuilder None => new("backdrop-blur-none");

    /// <summary>Adds <c>backdrop-blur-xs</c>.</summary>
    public static BackdropBlurBuilder Xs => new("backdrop-blur-xs");

    /// <summary>Adds <c>backdrop-blur-sm</c>.</summary>
    public static BackdropBlurBuilder Sm => new("backdrop-blur-sm");

    /// <summary>Adds <c>backdrop-blur-md</c>.</summary>
    public static BackdropBlurBuilder Md => new("backdrop-blur-md");

    /// <summary>Adds <c>backdrop-blur-lg</c>.</summary>
    public static BackdropBlurBuilder Lg => new("backdrop-blur-lg");

    /// <summary>Adds <c>backdrop-blur-xl</c>.</summary>
    public static BackdropBlurBuilder Xl => new("backdrop-blur-xl");

    /// <summary>Adds <c>backdrop-blur-2xl</c>.</summary>
    public static BackdropBlurBuilder TwoXl => new("backdrop-blur-2xl");

    /// <summary>Adds <c>backdrop-blur-3xl</c>.</summary>
    public static BackdropBlurBuilder ThreeXl => new("backdrop-blur-3xl");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropBlurBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-blur-"));
}
