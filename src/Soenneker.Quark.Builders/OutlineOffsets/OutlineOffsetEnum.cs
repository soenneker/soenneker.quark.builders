using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OutlineOffsetEnum
{
    public static readonly OutlineOffsetEnum Is0 = new("0");
    public static readonly OutlineOffsetEnum Is1 = new("1");
    public static readonly OutlineOffsetEnum Is2 = new("2");
    public static readonly OutlineOffsetEnum Is4 = new("4");
    public static readonly OutlineOffsetEnum Is8 = new("8");
}
