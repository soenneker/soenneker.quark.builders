using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the z index enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ZIndexEnum
{
    /// <summary>
    /// The negative1.
    /// </summary>
    public static readonly ZIndexEnum Negative1 = new("z-n1");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly ZIndexEnum Is0 = new("z-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly ZIndexEnum Is1 = new("z-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly ZIndexEnum Is2 = new("z-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly ZIndexEnum Is3 = new("z-3");
    /// <summary>
    /// The is10.
    /// </summary>
    public static readonly ZIndexEnum Is10 = new("z-10");
    /// <summary>
    /// The is50.
    /// </summary>
    public static readonly ZIndexEnum Is50 = new("z-50");
}
