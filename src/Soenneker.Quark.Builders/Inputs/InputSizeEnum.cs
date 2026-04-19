using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class InputSizeEnum
{
    public static readonly InputSizeEnum Default = new("default");
    public static readonly InputSizeEnum Sm = new("sm");
    public static readonly InputSizeEnum Lg = new("lg");
}
