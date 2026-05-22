using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ForcedColorAdjustEnum
{
    public static readonly ForcedColorAdjustEnum Auto = new("forced-color-adjust-auto");
    public static readonly ForcedColorAdjustEnum None = new("forced-color-adjust-none");
}
