using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexDirectionEnum
{
    public static readonly FlexDirectionEnum Row = new("flex-row");
    public static readonly FlexDirectionEnum RowReverse = new("flex-row-reverse");
    public static readonly FlexDirectionEnum Col = new("flex-col");
    public static readonly FlexDirectionEnum ColReverse = new("flex-col-reverse");
}
