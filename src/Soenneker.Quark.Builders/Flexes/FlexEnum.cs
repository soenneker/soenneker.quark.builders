using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexEnum
{
    public static readonly FlexEnum Is1 = new("flex-1");
    public static readonly FlexEnum Auto = new("flex-auto");
    public static readonly FlexEnum Initial = new("flex-initial");
    public static readonly FlexEnum None = new("flex-none");
}
