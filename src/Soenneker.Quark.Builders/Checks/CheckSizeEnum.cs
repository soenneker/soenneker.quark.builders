using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class CheckSizeEnum
{
    public static readonly CheckSizeEnum Default = new("default");
    public static readonly CheckSizeEnum Xs = new("xs");
    public static readonly CheckSizeEnum Sm = new("sm");
    public static readonly CheckSizeEnum Md = new("md");
    public static readonly CheckSizeEnum Lg = new("lg");
    public static readonly CheckSizeEnum Xl = new("xl");
    public static readonly CheckSizeEnum Xxl = new("xxl");
}
