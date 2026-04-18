using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class GapScaleEnum
{
    public static readonly GapScaleEnum Is0 = new("0");
    public static readonly GapScaleEnum Is1 = new("1");
    public static readonly GapScaleEnum Is2 = new("2");
    public static readonly GapScaleEnum Is3 = new("3");
    public static readonly GapScaleEnum Is4 = new("4");
    public static readonly GapScaleEnum Is5 = new("5");
}
