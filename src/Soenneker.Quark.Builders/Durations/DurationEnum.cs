using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DurationEnum
{
    public static readonly DurationEnum Is75 = new("75");
    public static readonly DurationEnum Is100 = new("100");
    public static readonly DurationEnum Is150 = new("150");
    public static readonly DurationEnum Is200 = new("200");
    public static readonly DurationEnum Is300 = new("300");
    public static readonly DurationEnum Is500 = new("500");
    public static readonly DurationEnum Is700 = new("700");
    public static readonly DurationEnum Is1000 = new("1000");
}
