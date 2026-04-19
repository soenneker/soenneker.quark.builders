using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class UnderlineOffsetEnum
{
    public static readonly UnderlineOffsetEnum Auto = new("underline-offset-auto");
    public static readonly UnderlineOffsetEnum Is0 = new("underline-offset-0");
    public static readonly UnderlineOffsetEnum Is1 = new("underline-offset-1");
    public static readonly UnderlineOffsetEnum Is2 = new("underline-offset-2");
    public static readonly UnderlineOffsetEnum Is4 = new("underline-offset-4");
    public static readonly UnderlineOffsetEnum Is8 = new("underline-offset-8");
}
