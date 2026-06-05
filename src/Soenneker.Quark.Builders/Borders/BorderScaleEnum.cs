using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the border scale enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BorderScaleEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly BorderScaleEnum Is0 = new("border-0");
    // Tailwind's canonical 1px border width utility is the unsuffixed `border` form.
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly BorderScaleEnum Is1 = new("border");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly BorderScaleEnum Is2 = new("border-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly BorderScaleEnum Is3 = new("border-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly BorderScaleEnum Is4 = new("border-4");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly BorderScaleEnum Is5 = new("border-5");
}
