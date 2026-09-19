namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for font stretching, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("font-stretch-", Responsive = true)]
public sealed class FontStretchBuilder : FinalClassUtilityBuilder<FontStretchBuilder>
{
    internal FontStretchBuilder()
    {
    }

    internal FontStretchBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>font-stretch-ultra-condensed</c>.</summary>
    public FontStretchBuilder UltraCondensed => ChainClass("font-stretch-ultra-condensed");

    /// <summary>Adds <c>font-stretch-extra-condensed</c>.</summary>
    public FontStretchBuilder ExtraCondensed => ChainClass("font-stretch-extra-condensed");

    /// <summary>Adds <c>font-stretch-condensed</c>.</summary>
    public FontStretchBuilder Condensed => ChainClass("font-stretch-condensed");

    /// <summary>Adds <c>font-stretch-semi-condensed</c>.</summary>
    public FontStretchBuilder SemiCondensed => ChainClass("font-stretch-semi-condensed");

    /// <summary>Adds <c>font-stretch-normal</c>.</summary>
    public FontStretchBuilder Normal => ChainClass("font-stretch-normal");

    /// <summary>Adds <c>font-stretch-semi-expanded</c>.</summary>
    public FontStretchBuilder SemiExpanded => ChainClass("font-stretch-semi-expanded");

    /// <summary>Adds <c>font-stretch-expanded</c>.</summary>
    public FontStretchBuilder Expanded => ChainClass("font-stretch-expanded");

    /// <summary>Adds <c>font-stretch-extra-expanded</c>.</summary>
    public FontStretchBuilder ExtraExpanded => ChainClass("font-stretch-extra-expanded");

    /// <summary>Adds <c>font-stretch-ultra-expanded</c>.</summary>
    public FontStretchBuilder UltraExpanded => ChainClass("font-stretch-ultra-expanded");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public FontStretchBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "font-stretch-"));
}
