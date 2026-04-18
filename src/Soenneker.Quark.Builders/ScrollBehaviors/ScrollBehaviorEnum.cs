using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScrollBehaviorEnum
{
    public static readonly ScrollBehaviorEnum Auto = new("scroll-auto");
    public static readonly ScrollBehaviorEnum Smooth = new("scroll-smooth");
}
