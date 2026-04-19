using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class SelectSizeEnum
{
    public static readonly SelectSizeEnum Default = new("default");
    public static readonly SelectSizeEnum Sm = new("sm");
}
