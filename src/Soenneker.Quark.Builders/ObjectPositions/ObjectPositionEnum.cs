using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ObjectPositionEnum
{
    public static readonly ObjectPositionEnum Center = new("object-center");
    public static readonly ObjectPositionEnum Top = new("object-top");
    public static readonly ObjectPositionEnum Right = new("object-right");
    public static readonly ObjectPositionEnum Bottom = new("object-bottom");
    public static readonly ObjectPositionEnum Left = new("object-left");
    public static readonly ObjectPositionEnum TopLeft = new("object-top-left");
    public static readonly ObjectPositionEnum TopRight = new("object-top-right");
    public static readonly ObjectPositionEnum BottomLeft = new("object-bottom-left");
    public static readonly ObjectPositionEnum BottomRight = new("object-bottom-right");
}
