using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class AccentColorEnum
{
    public static readonly AccentColorEnum Auto = new("accent-auto");
    public static readonly AccentColorEnum Primary = new("accent-primary");
    public static readonly AccentColorEnum Transparent = new("accent-transparent");
    public static readonly AccentColorEnum Current = new("accent-current");
}
