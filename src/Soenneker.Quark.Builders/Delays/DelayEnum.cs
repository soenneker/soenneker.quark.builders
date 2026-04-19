using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DelayEnum
{
    public static readonly DelayEnum Is75 = new("delay-75");
    public static readonly DelayEnum Is100 = new("delay-100");
    public static readonly DelayEnum Is150 = new("delay-150");
    public static readonly DelayEnum Is200 = new("delay-200");
    public static readonly DelayEnum Is300 = new("delay-300");
    public static readonly DelayEnum Is500 = new("delay-500");
    public static readonly DelayEnum Is700 = new("delay-700");
    public static readonly DelayEnum Is1000 = new("delay-1000");
}
