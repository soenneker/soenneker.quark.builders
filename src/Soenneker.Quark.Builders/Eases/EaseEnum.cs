using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class EaseEnum
{
    public static readonly EaseEnum Linear = new("ease-linear");
    public static readonly EaseEnum In = new("ease-in");
    public static readonly EaseEnum Out = new("ease-out");
    public static readonly EaseEnum InOut = new("ease-in-out");
}
