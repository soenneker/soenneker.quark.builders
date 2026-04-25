using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexEnum
{
    public static readonly FlexEnum Is1 = new("flex-1");
    public static readonly FlexEnum Auto = new("flex-auto");
    public static readonly FlexEnum Initial = new("flex-initial");
    public static readonly FlexEnum None = new("flex-none");
    public static readonly FlexEnum Wrap = new("flex-wrap");
    public static readonly FlexEnum WrapReverse = new("flex-wrap-reverse");
    public static readonly FlexEnum NoWrap = new("flex-nowrap");
    public static readonly FlexEnum Row = new("flex-row");
    public static readonly FlexEnum RowReverse = new("flex-row-reverse");
    public static readonly FlexEnum Col = new("flex-col");
    public static readonly FlexEnum ColReverse = new("flex-col-reverse");
}
