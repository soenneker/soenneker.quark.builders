using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TruncateEnum
{
    public static readonly TruncateEnum Default = new("truncate");
}
