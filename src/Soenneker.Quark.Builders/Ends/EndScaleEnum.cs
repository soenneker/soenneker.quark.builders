using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class EndScaleEnum
{
    public static readonly EndScaleEnum Is0 = new("0");
    public static readonly EndScaleEnum Is1 = new("1");
    public static readonly EndScaleEnum Is2 = new("2");
    public static readonly EndScaleEnum Is3 = new("3");
    public static readonly EndScaleEnum Is4 = new("4");
    public static readonly EndScaleEnum Is5 = new("5");
}
