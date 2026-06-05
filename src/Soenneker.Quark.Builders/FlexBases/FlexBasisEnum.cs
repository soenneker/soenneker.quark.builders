using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the flex basis enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FlexBasisEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly FlexBasisEnum Auto = new("basis-auto");
    /// <summary>
    /// The full.
    /// </summary>
    public static readonly FlexBasisEnum Full = new("basis-full");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly FlexBasisEnum Is0 = new("basis-0");
    /// <summary>
    /// The is1of2.
    /// </summary>
    public static readonly FlexBasisEnum Is1of2 = new("basis-1/2");
    /// <summary>
    /// The is1of3.
    /// </summary>
    public static readonly FlexBasisEnum Is1of3 = new("basis-1/3");
    /// <summary>
    /// The is2of3.
    /// </summary>
    public static readonly FlexBasisEnum Is2of3 = new("basis-2/3");
    /// <summary>
    /// The is1of4.
    /// </summary>
    public static readonly FlexBasisEnum Is1of4 = new("basis-1/4");
    /// <summary>
    /// The is3of4.
    /// </summary>
    public static readonly FlexBasisEnum Is3of4 = new("basis-3/4");
}
