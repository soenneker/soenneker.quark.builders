using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OriginEnum
{
    public static readonly OriginEnum Center = new("origin-center");
    public static readonly OriginEnum Top = new("origin-top");
    public static readonly OriginEnum TopRight = new("origin-top-right");
    public static readonly OriginEnum Right = new("origin-right");
    public static readonly OriginEnum BottomRight = new("origin-bottom-right");
    public static readonly OriginEnum Bottom = new("origin-bottom");
    public static readonly OriginEnum BottomLeft = new("origin-bottom-left");
    public static readonly OriginEnum Left = new("origin-left");
    public static readonly OriginEnum TopLeft = new("origin-top-left");
}
