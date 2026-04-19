using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScaleEnum
{
    public static readonly ScaleEnum Scale50 = new("scale-50");
    public static readonly ScaleEnum Scale75 = new("scale-75");
    public static readonly ScaleEnum Scale90 = new("scale-90");
    public static readonly ScaleEnum Scale95 = new("scale-95");
    public static readonly ScaleEnum Scale100 = new("scale-100");
    public static readonly ScaleEnum Scale105 = new("scale-105");
    public static readonly ScaleEnum Scale110 = new("scale-110");
    public static readonly ScaleEnum Scale125 = new("scale-125");
    public static readonly ScaleEnum Scale150 = new("scale-150");
}
