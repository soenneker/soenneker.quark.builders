using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class SwitchSizeEnum
{
    public static readonly SwitchSizeEnum Default = new("default");
    public static readonly SwitchSizeEnum Sm = new("sm");
}
