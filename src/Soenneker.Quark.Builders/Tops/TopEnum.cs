using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the top enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TopEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly TopEnum Is0 = new("top-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly TopEnum Is1 = new("top-1");
    /// <summary>
    /// The is1 5.
    /// </summary>
    public static readonly TopEnum Is1_5 = new("top-1.5");
    /// <summary>
    /// The is1of2.
    /// </summary>
    public static readonly TopEnum Is1of2 = new("top-1/2");
    /// <summary>
    /// The is1of3.
    /// </summary>
    public static readonly TopEnum Is1of3 = new("top-1/3");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly TopEnum Is2 = new("top-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly TopEnum Is3 = new("top-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly TopEnum Is4 = new("top-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly TopEnum Is5 = new("top-5");
    /// <summary>
    /// The is8.
    /// </summary>
    public static readonly TopEnum Is8 = new("top-8");
    /// <summary>
    /// The is12.
    /// </summary>
    public static readonly TopEnum Is12 = new("top-12");
    /// <summary>
    /// The is16.
    /// </summary>
    public static readonly TopEnum Is16 = new("top-16");
    /// <summary>
    /// The is24.
    /// </summary>
    public static readonly TopEnum Is24 = new("top-24");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly TopEnum Auto = new("top-auto");
    /// <summary>
    /// The px.
    /// </summary>
    public static readonly TopEnum Px = new("top-px");
}
