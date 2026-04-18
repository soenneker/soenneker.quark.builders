using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScaleType
{
    public static readonly ScaleType Is0 = new("0");
    public static readonly ScaleType Is1 = new("1");
    public static readonly ScaleType Is2 = new("2");
    public static readonly ScaleType Is3 = new("3");
    public static readonly ScaleType Is4 = new("4");
    public static readonly ScaleType Is5 = new("5");
    public static readonly ScaleType Is6 = new("6");
}
