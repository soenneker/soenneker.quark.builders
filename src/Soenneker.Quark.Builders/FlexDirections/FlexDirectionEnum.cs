using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexDirectionEnum
{
    public static readonly FlexDirectionEnum Row = new("row");
    public static readonly FlexDirectionEnum RowReverse = new("row-reverse");
    public static readonly FlexDirectionEnum Col = new("col");
    public static readonly FlexDirectionEnum ColReverse = new("col-reverse");
}
