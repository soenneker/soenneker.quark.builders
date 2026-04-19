using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class MarginScaleEnum
{
    public static readonly MarginScaleEnum Is0 = new("m-0");
    public static readonly MarginScaleEnum Is1 = new("m-1");
    public static readonly MarginScaleEnum Is2 = new("m-2");
    public static readonly MarginScaleEnum Is3 = new("m-3");
    public static readonly MarginScaleEnum Is4 = new("m-4");
    public static readonly MarginScaleEnum Is5 = new("m-5");
}
