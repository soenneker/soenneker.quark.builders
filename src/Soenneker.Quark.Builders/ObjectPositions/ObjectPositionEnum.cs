using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ObjectPositionEnum
{
    public static readonly ObjectPositionEnum Center = new("center");
    public static readonly ObjectPositionEnum Top = new("top");
    public static readonly ObjectPositionEnum Right = new("right");
    public static readonly ObjectPositionEnum Bottom = new("bottom");
    public static readonly ObjectPositionEnum Left = new("left");
    public static readonly ObjectPositionEnum TopLeft = new("top-left");
    public static readonly ObjectPositionEnum TopRight = new("top-right");
    public static readonly ObjectPositionEnum BottomLeft = new("bottom-left");
    public static readonly ObjectPositionEnum BottomRight = new("bottom-right");
}
