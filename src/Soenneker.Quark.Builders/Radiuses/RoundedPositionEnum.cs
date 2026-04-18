using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RoundedPositionEnum
{
    public static readonly RoundedPositionEnum All = new("");
    public static readonly RoundedPositionEnum Top = new("t");
    public static readonly RoundedPositionEnum Bottom = new("b");
    public static readonly RoundedPositionEnum Left = new("l");
    public static readonly RoundedPositionEnum Right = new("r");
    public static readonly RoundedPositionEnum TopLeft = new("tl");
    public static readonly RoundedPositionEnum TopRight = new("tr");
    public static readonly RoundedPositionEnum BottomLeft = new("bl");
    public static readonly RoundedPositionEnum BottomRight = new("br");
}
