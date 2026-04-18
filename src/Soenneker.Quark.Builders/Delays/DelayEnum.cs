using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DelayEnum
{
    public static readonly DelayEnum Is75 = new("75");
    public static readonly DelayEnum Is100 = new("100");
    public static readonly DelayEnum Is150 = new("150");
    public static readonly DelayEnum Is200 = new("200");
    public static readonly DelayEnum Is300 = new("300");
    public static readonly DelayEnum Is500 = new("500");
    public static readonly DelayEnum Is700 = new("700");
    public static readonly DelayEnum Is1000 = new("1000");
}
