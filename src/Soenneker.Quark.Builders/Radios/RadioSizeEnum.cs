using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RadioSizeEnum
{
    public static readonly RadioSizeEnum Default = new("size-4");
    public static readonly RadioSizeEnum Xs = new("h-3 w-3");
    public static readonly RadioSizeEnum Sm = new("h-3.5 w-3.5");
    public static readonly RadioSizeEnum Md = new("h-4 w-4");
    public static readonly RadioSizeEnum Lg = new("h-5 w-5");
    public static readonly RadioSizeEnum Xl = new("h-7 w-7");
    public static readonly RadioSizeEnum Xxl = new("h-8 w-8");
}
