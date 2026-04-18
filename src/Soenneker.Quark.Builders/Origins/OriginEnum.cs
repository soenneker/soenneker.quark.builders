using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OriginEnum
{
    public static readonly OriginEnum Center = new("center");
    public static readonly OriginEnum Top = new("top");
    public static readonly OriginEnum TopRight = new("top-right");
    public static readonly OriginEnum Right = new("right");
    public static readonly OriginEnum BottomRight = new("bottom-right");
    public static readonly OriginEnum Bottom = new("bottom");
    public static readonly OriginEnum BottomLeft = new("bottom-left");
    public static readonly OriginEnum Left = new("left");
    public static readonly OriginEnum TopLeft = new("top-left");
}
