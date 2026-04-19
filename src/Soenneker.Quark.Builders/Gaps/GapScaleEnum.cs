using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class GapScaleEnum
{
    public static readonly GapScaleEnum Is0 = new("gap-0");
    public static readonly GapScaleEnum Is1 = new("gap-1");
    public static readonly GapScaleEnum Is2 = new("gap-2");
    public static readonly GapScaleEnum Is3 = new("gap-3");
    public static readonly GapScaleEnum Is4 = new("gap-4");
    public static readonly GapScaleEnum Is5 = new("gap-5");
}
