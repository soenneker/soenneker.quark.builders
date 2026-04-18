using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class UnderlineOffsetEnum
{
    public static readonly UnderlineOffsetEnum Auto = new("auto");
    public static readonly UnderlineOffsetEnum Is0 = new("0");
    public static readonly UnderlineOffsetEnum Is1 = new("1");
    public static readonly UnderlineOffsetEnum Is2 = new("2");
    public static readonly UnderlineOffsetEnum Is4 = new("4");
    public static readonly UnderlineOffsetEnum Is8 = new("8");
}
