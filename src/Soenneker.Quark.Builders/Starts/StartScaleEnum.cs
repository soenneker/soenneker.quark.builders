using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StartScaleEnum
{
    public static readonly StartScaleEnum Is0 = new("0");
    public static readonly StartScaleEnum Is1 = new("1");
    public static readonly StartScaleEnum Is2 = new("2");
    public static readonly StartScaleEnum Is3 = new("3");
    public static readonly StartScaleEnum Is4 = new("4");
    public static readonly StartScaleEnum Is5 = new("5");
}
