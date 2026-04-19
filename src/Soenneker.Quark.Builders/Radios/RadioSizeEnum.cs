using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RadioSizeEnum
{
    public static readonly RadioSizeEnum Default = new("default");
    public static readonly RadioSizeEnum Xs = new("xs");
    public static readonly RadioSizeEnum Sm = new("sm");
    public static readonly RadioSizeEnum Md = new("md");
    public static readonly RadioSizeEnum Lg = new("lg");
    public static readonly RadioSizeEnum Xl = new("xl");
    public static readonly RadioSizeEnum Xxl = new("xxl");
}
