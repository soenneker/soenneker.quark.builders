namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for backdrop brightness filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("backdrop-brightness-", Responsive = true)]
public sealed class BackdropBrightnessBuilder : FinalClassUtilityBuilder<BackdropBrightnessBuilder>
{
    internal BackdropBrightnessBuilder()
    {
    }

    internal BackdropBrightnessBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>backdrop-brightness-0</c>.</summary>
    public BackdropBrightnessBuilder Is0 => ChainClass("backdrop-brightness-0");

    /// <summary>Adds <c>backdrop-brightness-50</c>.</summary>
    public BackdropBrightnessBuilder Is50 => ChainClass("backdrop-brightness-50");

    /// <summary>Adds <c>backdrop-brightness-75</c>.</summary>
    public BackdropBrightnessBuilder Is75 => ChainClass("backdrop-brightness-75");

    /// <summary>Adds <c>backdrop-brightness-90</c>.</summary>
    public BackdropBrightnessBuilder Is90 => ChainClass("backdrop-brightness-90");

    /// <summary>Adds <c>backdrop-brightness-95</c>.</summary>
    public BackdropBrightnessBuilder Is95 => ChainClass("backdrop-brightness-95");

    /// <summary>Adds <c>backdrop-brightness-100</c>.</summary>
    public BackdropBrightnessBuilder Is100 => ChainClass("backdrop-brightness-100");

    /// <summary>Adds <c>backdrop-brightness-105</c>.</summary>
    public BackdropBrightnessBuilder Is105 => ChainClass("backdrop-brightness-105");

    /// <summary>Adds <c>backdrop-brightness-110</c>.</summary>
    public BackdropBrightnessBuilder Is110 => ChainClass("backdrop-brightness-110");

    /// <summary>Adds <c>backdrop-brightness-125</c>.</summary>
    public BackdropBrightnessBuilder Is125 => ChainClass("backdrop-brightness-125");

    /// <summary>Adds <c>backdrop-brightness-150</c>.</summary>
    public BackdropBrightnessBuilder Is150 => ChainClass("backdrop-brightness-150");

    /// <summary>Adds <c>backdrop-brightness-200</c>.</summary>
    public BackdropBrightnessBuilder Is200 => ChainClass("backdrop-brightness-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BackdropBrightnessBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "backdrop-brightness-"));
}
