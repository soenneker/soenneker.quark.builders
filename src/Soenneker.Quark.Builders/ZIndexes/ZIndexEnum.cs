using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ZIndexEnum
{
    public static readonly ZIndexEnum N1 = new("z-n1");
    public static readonly ZIndexEnum Z0 = new("z-0");
    public static readonly ZIndexEnum Z1 = new("z-1");
    public static readonly ZIndexEnum Z2 = new("z-2");
    public static readonly ZIndexEnum Z3 = new("z-3");
    public static readonly ZIndexEnum Z10 = new("z-10");
    public static readonly ZIndexEnum Z50 = new("z-50");
}
