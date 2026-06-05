using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the rotate enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RotateEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly RotateEnum Is0 = new("rotate-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly RotateEnum Is1 = new("rotate-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly RotateEnum Is2 = new("rotate-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly RotateEnum Is3 = new("rotate-3");
    /// <summary>
    /// The is6.
    /// </summary>
    public static readonly RotateEnum Is6 = new("rotate-6");
    /// <summary>
    /// The is12.
    /// </summary>
    public static readonly RotateEnum Is12 = new("rotate-12");
    /// <summary>
    /// The is45.
    /// </summary>
    public static readonly RotateEnum Is45 = new("rotate-45");
    /// <summary>
    /// The is90.
    /// </summary>
    public static readonly RotateEnum Is90 = new("rotate-90");
    /// <summary>
    /// The is180.
    /// </summary>
    public static readonly RotateEnum Is180 = new("rotate-180");
}
