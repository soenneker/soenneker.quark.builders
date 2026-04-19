using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class SliderSizeEnum
{
    public static readonly SliderSizeEnum Default = new("default");
    public static readonly SliderSizeEnum Sm = new("sm");
    public static readonly SliderSizeEnum Lg = new("lg");
}
