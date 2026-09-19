namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop huerotate filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-hue-rotate-", Responsive = true)]
public sealed class BackdropHueRotateBuilder : FinalClassUtilityBuilder<BackdropHueRotateBuilder>
{
    internal BackdropHueRotateBuilder()
    {
    }

    internal BackdropHueRotateBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-hue-rotate-0</c>.</summary>
    public BackdropHueRotateBuilder Is0 => ChainClass("backdrop-hue-rotate-0");

    /// <summary>Adds <c>backdrop-hue-rotate-15</c>.</summary>
    public BackdropHueRotateBuilder Is15 => ChainClass("backdrop-hue-rotate-15");

    /// <summary>Adds <c>backdrop-hue-rotate-30</c>.</summary>
    public BackdropHueRotateBuilder Is30 => ChainClass("backdrop-hue-rotate-30");

    /// <summary>Adds <c>backdrop-hue-rotate-60</c>.</summary>
    public BackdropHueRotateBuilder Is60 => ChainClass("backdrop-hue-rotate-60");

    /// <summary>Adds <c>backdrop-hue-rotate-90</c>.</summary>
    public BackdropHueRotateBuilder Is90 => ChainClass("backdrop-hue-rotate-90");

    /// <summary>Adds <c>backdrop-hue-rotate-180</c>.</summary>
    public BackdropHueRotateBuilder Is180 => ChainClass("backdrop-hue-rotate-180");

    /// <summary>Adds <c>-backdrop-hue-rotate-90</c>.</summary>
    public BackdropHueRotateBuilder Negative90 => ChainClass("-backdrop-hue-rotate-90");

    /// <summary>Adds <c>-backdrop-hue-rotate-180</c>.</summary>
    public BackdropHueRotateBuilder Negative180 => ChainClass("-backdrop-hue-rotate-180");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropHueRotateBuilder Token(string value) => ChainClass(UtilityToken.WithSignedPrefix(value, "backdrop-hue-rotate-"));
}
