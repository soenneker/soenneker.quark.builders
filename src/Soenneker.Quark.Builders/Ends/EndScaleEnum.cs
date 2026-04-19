using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class EndScaleEnum
{
    public static readonly EndScaleEnum Is0 = new("end-0");
    public static readonly EndScaleEnum Is1 = new("end-1");
    public static readonly EndScaleEnum Is2 = new("end-2");
    public static readonly EndScaleEnum Is3 = new("end-3");
    public static readonly EndScaleEnum Is4 = new("end-4");
    public static readonly EndScaleEnum Is5 = new("end-5");
}
