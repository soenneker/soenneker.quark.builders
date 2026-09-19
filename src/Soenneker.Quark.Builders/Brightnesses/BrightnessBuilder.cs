namespace Soenneker.Quark;

/// <summary>
/// Builds Tailwind utilities for brightness filters, with responsive and state modifiers.
/// </summary>
[TailwindPrefix("brightness-", Responsive = true)]
public sealed class BrightnessBuilder : FinalClassUtilityBuilder<BrightnessBuilder>
{
    internal BrightnessBuilder()
    {
    }

    internal BrightnessBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>Adds <c>brightness-0</c>.</summary>
    public BrightnessBuilder Is0 => ChainClass("brightness-0");

    /// <summary>Adds <c>brightness-50</c>.</summary>
    public BrightnessBuilder Is50 => ChainClass("brightness-50");

    /// <summary>Adds <c>brightness-75</c>.</summary>
    public BrightnessBuilder Is75 => ChainClass("brightness-75");

    /// <summary>Adds <c>brightness-90</c>.</summary>
    public BrightnessBuilder Is90 => ChainClass("brightness-90");

    /// <summary>Adds <c>brightness-95</c>.</summary>
    public BrightnessBuilder Is95 => ChainClass("brightness-95");

    /// <summary>Adds <c>brightness-100</c>.</summary>
    public BrightnessBuilder Is100 => ChainClass("brightness-100");

    /// <summary>Adds <c>brightness-105</c>.</summary>
    public BrightnessBuilder Is105 => ChainClass("brightness-105");

    /// <summary>Adds <c>brightness-110</c>.</summary>
    public BrightnessBuilder Is110 => ChainClass("brightness-110");

    /// <summary>Adds <c>brightness-125</c>.</summary>
    public BrightnessBuilder Is125 => ChainClass("brightness-125");

    /// <summary>Adds <c>brightness-150</c>.</summary>
    public BrightnessBuilder Is150 => ChainClass("brightness-150");

    /// <summary>Adds <c>brightness-200</c>.</summary>
    public BrightnessBuilder Is200 => ChainClass("brightness-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>The current builder.</returns>
    public BrightnessBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "brightness-"));
}
