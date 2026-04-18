using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexEnum
{
    public static readonly FlexEnum Is1 = new("1");
    public static readonly FlexEnum Auto = new("auto");
    public static readonly FlexEnum Initial = new("initial");
    public static readonly FlexEnum None = new("none");
}
