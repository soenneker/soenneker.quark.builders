using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the rounded position enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RoundedPositionEnum
{
    /// <summary>
    /// The all.
    /// </summary>
    public static readonly RoundedPositionEnum All = new("");
    /// <summary>
    /// The top.
    /// </summary>
    public static readonly RoundedPositionEnum Top = new("t");
    /// <summary>
    /// The bottom.
    /// </summary>
    public static readonly RoundedPositionEnum Bottom = new("b");
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly RoundedPositionEnum Left = new("l");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly RoundedPositionEnum Right = new("r");
    /// <summary>
    /// The top left.
    /// </summary>
    public static readonly RoundedPositionEnum TopLeft = new("tl");
    /// <summary>
    /// The top right.
    /// </summary>
    public static readonly RoundedPositionEnum TopRight = new("tr");
    /// <summary>
    /// The bottom left.
    /// </summary>
    public static readonly RoundedPositionEnum BottomLeft = new("bl");
    /// <summary>
    /// The bottom right.
    /// </summary>
    public static readonly RoundedPositionEnum BottomRight = new("br");
}
