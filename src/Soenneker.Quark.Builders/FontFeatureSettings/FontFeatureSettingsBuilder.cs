namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for OpenType feature settings, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("font-features-", Responsive = true)]
public sealed class FontFeatureSettingsBuilder : FinalClassUtilityBuilder<FontFeatureSettingsBuilder>
{
    internal FontFeatureSettingsBuilder()
    {
    }

    internal FontFeatureSettingsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>font-features-[normal]</c>.</summary>
    public FontFeatureSettingsBuilder Normal => ChainClass("font-features-[normal]");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">The utility suffix, without the family prefix.</param>
    /// <returns>The current builder.</returns>
    public FontFeatureSettingsBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "font-features-"));
}
