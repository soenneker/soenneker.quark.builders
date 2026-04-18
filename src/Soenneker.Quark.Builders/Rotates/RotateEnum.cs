using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RotateEnum
{
    public static readonly RotateEnum Is0 = new("0");
    public static readonly RotateEnum Is1 = new("1");
    public static readonly RotateEnum Is2 = new("2");
    public static readonly RotateEnum Is3 = new("3");
    public static readonly RotateEnum Is6 = new("6");
    public static readonly RotateEnum Is12 = new("12");
    public static readonly RotateEnum Is45 = new("45");
    public static readonly RotateEnum Is90 = new("90");
    public static readonly RotateEnum Is180 = new("180");
}
