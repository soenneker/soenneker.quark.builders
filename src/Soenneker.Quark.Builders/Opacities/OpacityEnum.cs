using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OpacityEnum
{
    public static readonly OpacityEnum Is0 = new("opacity-0");
    public static readonly OpacityEnum Is25 = new("opacity-25");
    public static readonly OpacityEnum Is50 = new("opacity-50");
    public static readonly OpacityEnum Is60 = new("opacity-60");
    public static readonly OpacityEnum Is70 = new("opacity-70");
    public static readonly OpacityEnum Is75 = new("opacity-75");
    public static readonly OpacityEnum Is100 = new("opacity-100");
}
