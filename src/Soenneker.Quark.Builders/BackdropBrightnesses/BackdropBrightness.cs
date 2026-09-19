namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for backdrop brightness filters.
/// </summary>
[TailwindModifiers(typeof(BackdropBrightnessBuilder))]
public static partial class BackdropBrightness
{
    /// <summary>Adds <c>backdrop-brightness-0</c>.</summary>
    public static BackdropBrightnessBuilder Is0 => new("backdrop-brightness-0");

    /// <summary>Adds <c>backdrop-brightness-50</c>.</summary>
    public static BackdropBrightnessBuilder Is50 => new("backdrop-brightness-50");

    /// <summary>Adds <c>backdrop-brightness-75</c>.</summary>
    public static BackdropBrightnessBuilder Is75 => new("backdrop-brightness-75");

    /// <summary>Adds <c>backdrop-brightness-90</c>.</summary>
    public static BackdropBrightnessBuilder Is90 => new("backdrop-brightness-90");

    /// <summary>Adds <c>backdrop-brightness-95</c>.</summary>
    public static BackdropBrightnessBuilder Is95 => new("backdrop-brightness-95");

    /// <summary>Adds <c>backdrop-brightness-100</c>.</summary>
    public static BackdropBrightnessBuilder Is100 => new("backdrop-brightness-100");

    /// <summary>Adds <c>backdrop-brightness-105</c>.</summary>
    public static BackdropBrightnessBuilder Is105 => new("backdrop-brightness-105");

    /// <summary>Adds <c>backdrop-brightness-110</c>.</summary>
    public static BackdropBrightnessBuilder Is110 => new("backdrop-brightness-110");

    /// <summary>Adds <c>backdrop-brightness-125</c>.</summary>
    public static BackdropBrightnessBuilder Is125 => new("backdrop-brightness-125");

    /// <summary>Adds <c>backdrop-brightness-150</c>.</summary>
    public static BackdropBrightnessBuilder Is150 => new("backdrop-brightness-150");

    /// <summary>Adds <c>backdrop-brightness-200</c>.</summary>
    public static BackdropBrightnessBuilder Is200 => new("backdrop-brightness-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static BackdropBrightnessBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "backdrop-brightness-"));
}
