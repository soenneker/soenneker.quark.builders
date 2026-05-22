using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FlexBasisEnum
{
    public static readonly FlexBasisEnum Auto = new("basis-auto");
    public static readonly FlexBasisEnum Full = new("basis-full");
    public static readonly FlexBasisEnum Is0 = new("basis-0");
    public static readonly FlexBasisEnum Is1of2 = new("basis-1/2");
    public static readonly FlexBasisEnum Is1of3 = new("basis-1/3");
    public static readonly FlexBasisEnum Is2of3 = new("basis-2/3");
    public static readonly FlexBasisEnum Is1of4 = new("basis-1/4");
    public static readonly FlexBasisEnum Is3of4 = new("basis-3/4");
}
