using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the inset scale enum.
/// </summary>
[EnumValue<string>]
public sealed partial class InsetScaleEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly InsetScaleEnum Is0 = new("inset-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly InsetScaleEnum Is1 = new("inset-1");
    /// <summary>
    /// The is1 5.
    /// </summary>
    public static readonly InsetScaleEnum Is1_5 = new("inset-1.5");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly InsetScaleEnum Is2 = new("inset-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly InsetScaleEnum Is3 = new("inset-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly InsetScaleEnum Is4 = new("inset-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly InsetScaleEnum Is5 = new("inset-5");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly InsetScaleEnum Auto = new("inset-auto");
    /// <summary>
    /// The px.
    /// </summary>
    public static readonly InsetScaleEnum Px = new("inset-px");
}
