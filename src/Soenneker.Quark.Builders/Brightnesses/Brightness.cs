namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for brightness filters.
/// </summary>
[TailwindModifiers(typeof(BrightnessBuilder))]
public static partial class Brightness
{
    /// <summary>Adds <c>brightness-0</c>.</summary>
    public static BrightnessBuilder Is0 => new("brightness-0");

    /// <summary>Adds <c>brightness-50</c>.</summary>
    public static BrightnessBuilder Is50 => new("brightness-50");

    /// <summary>Adds <c>brightness-75</c>.</summary>
    public static BrightnessBuilder Is75 => new("brightness-75");

    /// <summary>Adds <c>brightness-90</c>.</summary>
    public static BrightnessBuilder Is90 => new("brightness-90");

    /// <summary>Adds <c>brightness-95</c>.</summary>
    public static BrightnessBuilder Is95 => new("brightness-95");

    /// <summary>Adds <c>brightness-100</c>.</summary>
    public static BrightnessBuilder Is100 => new("brightness-100");

    /// <summary>Adds <c>brightness-105</c>.</summary>
    public static BrightnessBuilder Is105 => new("brightness-105");

    /// <summary>Adds <c>brightness-110</c>.</summary>
    public static BrightnessBuilder Is110 => new("brightness-110");

    /// <summary>Adds <c>brightness-125</c>.</summary>
    public static BrightnessBuilder Is125 => new("brightness-125");

    /// <summary>Adds <c>brightness-150</c>.</summary>
    public static BrightnessBuilder Is150 => new("brightness-150");

    /// <summary>Adds <c>brightness-200</c>.</summary>
    public static BrightnessBuilder Is200 => new("brightness-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BrightnessBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "brightness-"));
}
