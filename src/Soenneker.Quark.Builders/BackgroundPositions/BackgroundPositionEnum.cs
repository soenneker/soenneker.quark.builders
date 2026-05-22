using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BackgroundPositionEnum
{
    public static readonly BackgroundPositionEnum Bottom = new("bg-bottom");
    public static readonly BackgroundPositionEnum Center = new("bg-center");
    public static readonly BackgroundPositionEnum Left = new("bg-left");
    public static readonly BackgroundPositionEnum LeftBottom = new("bg-left-bottom");
    public static readonly BackgroundPositionEnum LeftTop = new("bg-left-top");
    public static readonly BackgroundPositionEnum Right = new("bg-right");
    public static readonly BackgroundPositionEnum RightBottom = new("bg-right-bottom");
    public static readonly BackgroundPositionEnum RightTop = new("bg-right-top");
    public static readonly BackgroundPositionEnum Top = new("bg-top");
}
