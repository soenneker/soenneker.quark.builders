using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the origin enum.
/// </summary>
[EnumValue<string>]
public sealed partial class OriginEnum
{
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly OriginEnum Center = new("origin-center");
    /// <summary>
    /// The top.
    /// </summary>
    public static readonly OriginEnum Top = new("origin-top");
    /// <summary>
    /// The top right.
    /// </summary>
    public static readonly OriginEnum TopRight = new("origin-top-right");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly OriginEnum Right = new("origin-right");
    /// <summary>
    /// The bottom right.
    /// </summary>
    public static readonly OriginEnum BottomRight = new("origin-bottom-right");
    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly OriginEnum Bottom = new("origin-bottom");
    /// <summary>
    /// The bottom left.
    /// </summary>
    public static readonly OriginEnum BottomLeft = new("origin-bottom-left");
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly OriginEnum Left = new("origin-left");
    /// <summary>
    /// The top left.
    /// </summary>
    public static readonly OriginEnum TopLeft = new("origin-top-left");
}
