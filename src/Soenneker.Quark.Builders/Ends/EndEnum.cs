using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the end enum.
/// </summary>
[EnumValue<string>]
public sealed partial class EndEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly EndEnum Is0 = new("end-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly EndEnum Is1 = new("end-1");
    /// <summary>
    /// The is1 5.
    /// </summary>
    public static readonly EndEnum Is1_5 = new("end-1.5");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly EndEnum Is2 = new("end-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly EndEnum Is3 = new("end-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly EndEnum Is4 = new("end-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly EndEnum Is5 = new("end-5");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly EndEnum Auto = new("end-auto");
    /// <summary>
    /// The px.
    /// </summary>
    public static readonly EndEnum Px = new("end-px");
}
