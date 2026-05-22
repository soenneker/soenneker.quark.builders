using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class HyphenEnum
{
    public static readonly HyphenEnum None = new("hyphens-none");
    public static readonly HyphenEnum Manual = new("hyphens-manual");
    public static readonly HyphenEnum Auto = new("hyphens-auto");
}
