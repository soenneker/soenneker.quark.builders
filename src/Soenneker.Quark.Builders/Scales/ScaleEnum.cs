using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScaleEnum
{
    public static readonly ScaleEnum Scale50 = new("50");
    public static readonly ScaleEnum Scale75 = new("75");
    public static readonly ScaleEnum Scale90 = new("90");
    public static readonly ScaleEnum Scale95 = new("95");
    public static readonly ScaleEnum Scale100 = new("100");
    public static readonly ScaleEnum Scale105 = new("105");
    public static readonly ScaleEnum Scale110 = new("110");
    public static readonly ScaleEnum Scale125 = new("125");
    public static readonly ScaleEnum Scale150 = new("150");
}
