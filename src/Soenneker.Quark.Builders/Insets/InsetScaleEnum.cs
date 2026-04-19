using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class InsetScaleEnum
{
    public static readonly InsetScaleEnum Is0 = new("inset-0");
    public static readonly InsetScaleEnum Is1 = new("inset-1");
    public static readonly InsetScaleEnum Is2 = new("inset-2");
    public static readonly InsetScaleEnum Is3 = new("inset-3");
    public static readonly InsetScaleEnum Is4 = new("inset-4");
    public static readonly InsetScaleEnum Is5 = new("inset-5");
    public static readonly InsetScaleEnum Auto = new("inset-auto");
    public static readonly InsetScaleEnum Px = new("inset-px");
}
