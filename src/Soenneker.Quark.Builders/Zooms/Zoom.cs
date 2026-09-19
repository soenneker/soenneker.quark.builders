namespace Soenneker.Quark;

/// <summary>
/// Creates Tailwind utilities for CSS zoom.
/// </summary>
[TailwindModifiers(typeof(ZoomBuilder))]
public static partial class Zoom
{
    /// <summary>Adds <c>zoom-50</c>.</summary>
    public static ZoomBuilder Is50 => new("zoom-50");

    /// <summary>Adds <c>zoom-75</c>.</summary>
    public static ZoomBuilder Is75 => new("zoom-75");

    /// <summary>Adds <c>zoom-90</c>.</summary>
    public static ZoomBuilder Is90 => new("zoom-90");

    /// <summary>Adds <c>zoom-100</c>.</summary>
    public static ZoomBuilder Is100 => new("zoom-100");

    /// <summary>Adds <c>zoom-110</c>.</summary>
    public static ZoomBuilder Is110 => new("zoom-110");

    /// <summary>Adds <c>zoom-125</c>.</summary>
    public static ZoomBuilder Is125 => new("zoom-125");

    /// <summary>Adds <c>zoom-150</c>.</summary>
    public static ZoomBuilder Is150 => new("zoom-150");

    /// <summary>Adds <c>zoom-200</c>.</summary>
    public static ZoomBuilder Is200 => new("zoom-200");

    /// <summary>Adds an arbitrary utility. Apply variants with fluent modifiers.</summary>
    /// <param name="value">A utility suffix or a complete utility with this family's prefix.</param>
    /// <returns>A new builder containing the utility.</returns>
    public static ZoomBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "zoom-"));
}
