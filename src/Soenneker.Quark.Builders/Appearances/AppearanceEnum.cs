using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class AppearanceEnum
{
    public static readonly AppearanceEnum None = new("appearance-none");
    public static readonly AppearanceEnum Auto = new("appearance-auto");
}
