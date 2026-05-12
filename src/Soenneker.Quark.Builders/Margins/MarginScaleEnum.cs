using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class MarginScaleEnum
{
    public static readonly MarginScaleEnum Is0 = new("m-0");
    public static readonly MarginScaleEnum Is0_5 = new("m-0.5");
    public static readonly MarginScaleEnum Is1 = new("m-1");
    public static readonly MarginScaleEnum Is1_5 = new("m-1.5");
    public static readonly MarginScaleEnum Is2 = new("m-2");
    public static readonly MarginScaleEnum Is3 = new("m-3");
    public static readonly MarginScaleEnum Is3_5 = new("m-3.5");
    public static readonly MarginScaleEnum Is4 = new("m-4");
    public static readonly MarginScaleEnum Is5 = new("m-5");
    public static readonly MarginScaleEnum Is6 = new("m-6");
    public static readonly MarginScaleEnum Is8 = new("m-8");
    public static readonly MarginScaleEnum Is12 = new("m-12");
    public static readonly MarginScaleEnum Auto = new("m-auto");
    public static readonly MarginScaleEnum Negative1 = new("-m-1");
    public static readonly MarginScaleEnum Negative2 = new("-m-2");
}
