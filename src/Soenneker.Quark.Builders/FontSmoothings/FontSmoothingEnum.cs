using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the font smoothing enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FontSmoothingEnum
{
    /// <summary>
    /// The antialiased.
    /// </summary>
    public static readonly FontSmoothingEnum Antialiased = new("antialiased");
    /// <summary>
    /// The subpixel antialiased.
    /// </summary>
    public static readonly FontSmoothingEnum SubpixelAntialiased = new("subpixel-antialiased");
}
