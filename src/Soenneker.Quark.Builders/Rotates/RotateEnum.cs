using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RotateEnum
{
    public static readonly RotateEnum Is0 = new("rotate-0");
    public static readonly RotateEnum Is1 = new("rotate-1");
    public static readonly RotateEnum Is2 = new("rotate-2");
    public static readonly RotateEnum Is3 = new("rotate-3");
    public static readonly RotateEnum Is6 = new("rotate-6");
    public static readonly RotateEnum Is12 = new("rotate-12");
    public static readonly RotateEnum Is45 = new("rotate-45");
    public static readonly RotateEnum Is90 = new("rotate-90");
    public static readonly RotateEnum Is180 = new("rotate-180");
}
