using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the object fit enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ObjectFitEnum
{
    /// <summary>
    /// The contain.
    /// </summary>
    public static readonly ObjectFitEnum Contain = new("object-contain");
    /// <summary>
    /// The cover.
    /// </summary>
    public static readonly ObjectFitEnum Cover = new("object-cover");
    /// <summary>
    /// The fill.
    /// </summary>
    public static readonly ObjectFitEnum Fill = new("object-fill");
    /// <summary>
    /// The scale down.
    /// </summary>
    public static readonly ObjectFitEnum ScaleDown = new("object-scale-down");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ObjectFitEnum None = new("object-none");
}
