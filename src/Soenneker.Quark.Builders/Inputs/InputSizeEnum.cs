using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class InputSizeEnum
{
    public static readonly InputSizeEnum Default = new("");
    public static readonly InputSizeEnum Sm = new("h-9 text-xs");
    public static readonly InputSizeEnum Lg = new("h-11 text-base");
}
