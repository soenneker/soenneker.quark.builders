using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the object position enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ObjectPositionEnum
{
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly ObjectPositionEnum Center = new("object-center");
    /// <summary>
    /// The top.
    /// </summary>
    public static readonly ObjectPositionEnum Top = new("object-top");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly ObjectPositionEnum Right = new("object-right");
    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly ObjectPositionEnum Bottom = new("object-bottom");
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly ObjectPositionEnum Left = new("object-left");
    /// <summary>
    /// The top left.
    /// </summary>
    public static readonly ObjectPositionEnum TopLeft = new("object-top-left");
    /// <summary>
    /// The top right.
    /// </summary>
    public static readonly ObjectPositionEnum TopRight = new("object-top-right");
    /// <summary>
    /// The bottom left.
    /// </summary>
    public static readonly ObjectPositionEnum BottomLeft = new("object-bottom-left");
    /// <summary>
    /// The bottom right.
    /// </summary>
    public static readonly ObjectPositionEnum BottomRight = new("object-bottom-right");
}
