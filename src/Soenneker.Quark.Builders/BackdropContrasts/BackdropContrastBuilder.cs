namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop contrast filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-contrast-", Responsive = true)]
public sealed class BackdropContrastBuilder : FinalClassUtilityBuilder<BackdropContrastBuilder>
{
    internal BackdropContrastBuilder()
    {
    }

    internal BackdropContrastBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-contrast-0</c>.</summary>
    public BackdropContrastBuilder Is0 => ChainClass("backdrop-contrast-0");

    /// <summary>Adds <c>backdrop-contrast-50</c>.</summary>
    public BackdropContrastBuilder Is50 => ChainClass("backdrop-contrast-50");

    /// <summary>Adds <c>backdrop-contrast-75</c>.</summary>
    public BackdropContrastBuilder Is75 => ChainClass("backdrop-contrast-75");

    /// <summary>Adds <c>backdrop-contrast-100</c>.</summary>
    public BackdropContrastBuilder Is100 => ChainClass("backdrop-contrast-100");

    /// <summary>Adds <c>backdrop-contrast-125</c>.</summary>
    public BackdropContrastBuilder Is125 => ChainClass("backdrop-contrast-125");

    /// <summary>Adds <c>backdrop-contrast-150</c>.</summary>
    public BackdropContrastBuilder Is150 => ChainClass("backdrop-contrast-150");

    /// <summary>Adds <c>backdrop-contrast-200</c>.</summary>
    public BackdropContrastBuilder Is200 => ChainClass("backdrop-contrast-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropContrastBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-contrast-"));
}
