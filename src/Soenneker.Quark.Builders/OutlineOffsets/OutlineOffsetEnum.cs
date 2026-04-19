using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OutlineOffsetEnum
{
    public static readonly OutlineOffsetEnum Is0 = new("outline-offset-0");
    public static readonly OutlineOffsetEnum Is1 = new("outline-offset-1");
    public static readonly OutlineOffsetEnum Is2 = new("outline-offset-2");
    public static readonly OutlineOffsetEnum Is4 = new("outline-offset-4");
    public static readonly OutlineOffsetEnum Is8 = new("outline-offset-8");
}
