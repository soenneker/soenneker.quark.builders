using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the font weight enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FontWeightEnum
{
    /// <summary>
    /// The extralight.
    /// </summary>
    public static readonly FontWeightEnum Extralight = new("font-extralight");
    /// <summary>
    /// The light.
    /// </summary>
    public static readonly FontWeightEnum Light = new("font-light");
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly FontWeightEnum Normal = new("font-normal");
    /// <summary>
    /// The medium.
    /// </summary>
    public static readonly FontWeightEnum Medium = new("font-medium");
    /// <summary>
    /// The semibold.
    /// </summary>
    public static readonly FontWeightEnum Semibold = new("font-semibold");
    /// <summary>
    /// The bold.
    /// </summary>
    public static readonly FontWeightEnum Bold = new("font-bold");
    /// <summary>
    /// The extrabold.
    /// </summary>
    public static readonly FontWeightEnum Extrabold = new("font-extrabold");
}
