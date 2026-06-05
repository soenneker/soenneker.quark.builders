using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the scale enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ScaleEnum
{
    /// <summary>
    /// The scale50.
    /// </summary>
    public static readonly ScaleEnum Scale50 = new("scale-50");
    /// <summary>
    /// The scale75.
    /// </summary>
    public static readonly ScaleEnum Scale75 = new("scale-75");
    /// <summary>
    /// The scale90.
    /// </summary>
    public static readonly ScaleEnum Scale90 = new("scale-90");
    /// <summary>
    /// The scale95.
    /// </summary>
    public static readonly ScaleEnum Scale95 = new("scale-95");
    /// <summary>
    /// The scale100.
    /// </summary>
    public static readonly ScaleEnum Scale100 = new("scale-100");
    /// <summary>
    /// The scale105.
    /// </summary>
    public static readonly ScaleEnum Scale105 = new("scale-105");
    /// <summary>
    /// The scale110.
    /// </summary>
    public static readonly ScaleEnum Scale110 = new("scale-110");
    /// <summary>
    /// The scale125.
    /// </summary>
    public static readonly ScaleEnum Scale125 = new("scale-125");
    /// <summary>
    /// The scale150.
    /// </summary>
    public static readonly ScaleEnum Scale150 = new("scale-150");
}
