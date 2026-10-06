namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for OpenType feature settings.
/// </summary>
[TailwindModifiers(typeof(FontFeatureSettingsBuilder))]
public static partial class FontFeatureSettings
{
    /// <summary>Adds <c>font-features-[normal]</c>.</summary>
    public static FontFeatureSettingsBuilder Normal => new("font-features-[normal]");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static FontFeatureSettingsBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "font-features-"));
}
