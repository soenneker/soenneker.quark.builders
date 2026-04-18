using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class EaseEnum
{
    public static readonly EaseEnum Linear = new("linear");
    public static readonly EaseEnum In = new("in");
    public static readonly EaseEnum Out = new("out");
    public static readonly EaseEnum InOut = new("in-out");
}
