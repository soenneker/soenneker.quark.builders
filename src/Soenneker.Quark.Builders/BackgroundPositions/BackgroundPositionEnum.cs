using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the background position enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BackgroundPositionEnum
{
    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly BackgroundPositionEnum Bottom = new("bg-bottom");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly BackgroundPositionEnum Center = new("bg-center");
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly BackgroundPositionEnum Left = new("bg-left");
    /// <summary>
    /// The left bottom.
    /// </summary>
    public static readonly BackgroundPositionEnum LeftBottom = new("bg-left-bottom");
    /// <summary>
    /// The left top.
    /// </summary>
    public static readonly BackgroundPositionEnum LeftTop = new("bg-left-top");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly BackgroundPositionEnum Right = new("bg-right");
    /// <summary>
    /// The right bottom.
    /// </summary>
    public static readonly BackgroundPositionEnum RightBottom = new("bg-right-bottom");
    /// <summary>
    /// The right top.
    /// </summary>
    public static readonly BackgroundPositionEnum RightTop = new("bg-right-top");
    /// <summary>
    /// The top.
    /// </summary>
    public static readonly BackgroundPositionEnum Top = new("bg-top");
}
