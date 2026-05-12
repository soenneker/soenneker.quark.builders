using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DurationEnum
{
    public static readonly DurationEnum Is0 = new("duration-0");
    public static readonly DurationEnum Is75 = new("duration-75");
    public static readonly DurationEnum Is100 = new("duration-100");
    public static readonly DurationEnum Is150 = new("duration-150");
    public static readonly DurationEnum Is200 = new("duration-200");
    public static readonly DurationEnum Is300 = new("duration-300");
    public static readonly DurationEnum Is500 = new("duration-500");
    public static readonly DurationEnum Is700 = new("duration-700");
    public static readonly DurationEnum Is1000 = new("duration-1000");
}
