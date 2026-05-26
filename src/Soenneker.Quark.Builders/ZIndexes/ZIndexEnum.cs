using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ZIndexEnum
{
    public static readonly ZIndexEnum Negative1 = new("z-n1");
    public static readonly ZIndexEnum Is0 = new("z-0");
    public static readonly ZIndexEnum Is1 = new("z-1");
    public static readonly ZIndexEnum Is2 = new("z-2");
    public static readonly ZIndexEnum Is3 = new("z-3");
    public static readonly ZIndexEnum Is10 = new("z-10");
    public static readonly ZIndexEnum Is50 = new("z-50");
}
