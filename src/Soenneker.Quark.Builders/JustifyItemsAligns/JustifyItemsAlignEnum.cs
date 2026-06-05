using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the justify items align enum.
/// </summary>
[EnumValue<string>]
public sealed partial class JustifyItemsAlignEnum
{
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly JustifyItemsAlignEnum Normal = new("justify-items-normal");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly JustifyItemsAlignEnum Start = new("justify-items-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly JustifyItemsAlignEnum End = new("justify-items-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly JustifyItemsAlignEnum Center = new("justify-items-center");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly JustifyItemsAlignEnum Stretch = new("justify-items-stretch");
}
