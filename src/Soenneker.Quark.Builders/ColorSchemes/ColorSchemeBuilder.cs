namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for browser color schemes, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("scheme-", Responsive = true)]
public sealed class ColorSchemeBuilder : FinalClassUtilityBuilder<ColorSchemeBuilder>
{
    internal ColorSchemeBuilder()
    {
    }

    internal ColorSchemeBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>scheme-normal</c>.</summary>
    public ColorSchemeBuilder Normal => ChainClass("scheme-normal");

    /// <summary>Adds <c>scheme-light</c>.</summary>
    public ColorSchemeBuilder Light => ChainClass("scheme-light");

    /// <summary>Adds <c>scheme-dark</c>.</summary>
    public ColorSchemeBuilder Dark => ChainClass("scheme-dark");

    /// <summary>Adds <c>scheme-light-dark</c>.</summary>
    public ColorSchemeBuilder LightDark => ChainClass("scheme-light-dark");

    /// <summary>Adds <c>scheme-only-light</c>.</summary>
    public ColorSchemeBuilder OnlyLight => ChainClass("scheme-only-light");

    /// <summary>Adds <c>scheme-only-dark</c>.</summary>
    public ColorSchemeBuilder OnlyDark => ChainClass("scheme-only-dark");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public ColorSchemeBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "scheme-"));
}
