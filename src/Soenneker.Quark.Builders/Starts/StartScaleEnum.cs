using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StartScaleEnum
{
    public static readonly StartScaleEnum Is0 = new("start-0");
    public static readonly StartScaleEnum Is1 = new("start-1");
    public static readonly StartScaleEnum Is2 = new("start-2");
    public static readonly StartScaleEnum Is3 = new("start-3");
    public static readonly StartScaleEnum Is4 = new("start-4");
    public static readonly StartScaleEnum Is5 = new("start-5");
}
