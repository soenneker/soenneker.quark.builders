using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexWrapEnum
{
    public static readonly FlexWrapEnum Wrap = new("wrap");
    public static readonly FlexWrapEnum WrapReverse = new("wrap-reverse");
    public static readonly FlexWrapEnum NoWrap = new("nowrap");
}
