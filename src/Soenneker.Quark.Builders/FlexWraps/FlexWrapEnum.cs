using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexWrapEnum
{
    public static readonly FlexWrapEnum Wrap = new("flex-wrap");
    public static readonly FlexWrapEnum WrapReverse = new("flex-wrap-reverse");
    public static readonly FlexWrapEnum NoWrap = new("flex-nowrap");
}
