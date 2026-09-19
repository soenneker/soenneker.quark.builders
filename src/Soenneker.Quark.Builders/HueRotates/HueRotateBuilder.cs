namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for huerotate filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("hue-rotate-", Responsive = true)]
public sealed class HueRotateBuilder : FinalClassUtilityBuilder<HueRotateBuilder>
{
    internal HueRotateBuilder()
    {
    }

    internal HueRotateBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>hue-rotate-0</c>.</summary>
    public HueRotateBuilder Is0 => ChainClass("hue-rotate-0");

    /// <summary>Adds <c>hue-rotate-15</c>.</summary>
    public HueRotateBuilder Is15 => ChainClass("hue-rotate-15");

    /// <summary>Adds <c>hue-rotate-30</c>.</summary>
    public HueRotateBuilder Is30 => ChainClass("hue-rotate-30");

    /// <summary>Adds <c>hue-rotate-60</c>.</summary>
    public HueRotateBuilder Is60 => ChainClass("hue-rotate-60");

    /// <summary>Adds <c>hue-rotate-90</c>.</summary>
    public HueRotateBuilder Is90 => ChainClass("hue-rotate-90");

    /// <summary>Adds <c>hue-rotate-180</c>.</summary>
    public HueRotateBuilder Is180 => ChainClass("hue-rotate-180");

    /// <summary>Adds <c>-hue-rotate-90</c>.</summary>
    public HueRotateBuilder Negative90 => ChainClass("-hue-rotate-90");

    /// <summary>Adds <c>-hue-rotate-180</c>.</summary>
    public HueRotateBuilder Negative180 => ChainClass("-hue-rotate-180");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public HueRotateBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "hue-rotate-"));
}
