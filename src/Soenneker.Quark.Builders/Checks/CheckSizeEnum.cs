using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class CheckSizeEnum
{
    public static readonly CheckSizeEnum Default = new("size-4");
    public static readonly CheckSizeEnum Xs = new("h-3 w-3");
    public static readonly CheckSizeEnum Sm = new("h-3.5 w-3.5");
    public static readonly CheckSizeEnum Md = new("h-4 w-4");
    public static readonly CheckSizeEnum Lg = new("h-5 w-5");
    public static readonly CheckSizeEnum Xl = new("h-7 w-7");
    public static readonly CheckSizeEnum Xxl = new("h-8 w-8");
}
