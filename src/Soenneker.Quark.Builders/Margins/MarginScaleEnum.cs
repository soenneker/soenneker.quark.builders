using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class MarginScaleEnum
{
    public static readonly MarginScaleEnum Is0 = new("0");
    public static readonly MarginScaleEnum Is1 = new("1");
    public static readonly MarginScaleEnum Is2 = new("2");
    public static readonly MarginScaleEnum Is3 = new("3");
    public static readonly MarginScaleEnum Is4 = new("4");
    public static readonly MarginScaleEnum Is5 = new("5");
}
