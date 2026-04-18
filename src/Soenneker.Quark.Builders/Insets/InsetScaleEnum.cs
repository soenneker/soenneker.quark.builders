using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class InsetScaleEnum
{
    public static readonly InsetScaleEnum Is0 = new("0");
    public static readonly InsetScaleEnum Is1 = new("1");
    public static readonly InsetScaleEnum Is2 = new("2");
    public static readonly InsetScaleEnum Is3 = new("3");
    public static readonly InsetScaleEnum Is4 = new("4");
    public static readonly InsetScaleEnum Is5 = new("5");
    public static readonly InsetScaleEnum Auto = new("auto");
    public static readonly InsetScaleEnum Px = new("px");
}
