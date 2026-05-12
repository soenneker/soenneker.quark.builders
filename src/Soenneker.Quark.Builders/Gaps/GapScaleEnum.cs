using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class GapScaleEnum
{
    public static readonly GapScaleEnum Is0 = new("gap-0");
    public static readonly GapScaleEnum Is0_25 = new("gap-0.25");
    public static readonly GapScaleEnum Is0_5 = new("gap-0.5");
    public static readonly GapScaleEnum Is1 = new("gap-1");
    public static readonly GapScaleEnum Is1_25 = new("gap-1.25");
    public static readonly GapScaleEnum Is1_5 = new("gap-1.5");
    public static readonly GapScaleEnum Is2 = new("gap-2");
    public static readonly GapScaleEnum Is2_5 = new("gap-2.5");
    public static readonly GapScaleEnum Is3 = new("gap-3");
    public static readonly GapScaleEnum Is4 = new("gap-4");
    public static readonly GapScaleEnum Is5 = new("gap-5");
    public static readonly GapScaleEnum Is6 = new("gap-6");
    public static readonly GapScaleEnum Is8 = new("gap-8");
    public static readonly GapScaleEnum Is10 = new("gap-10");
    public static readonly GapScaleEnum Is12 = new("gap-12");
}
