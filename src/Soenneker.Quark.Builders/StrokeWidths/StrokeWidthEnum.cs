using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class StrokeWidthEnum
{
    public static readonly StrokeWidthEnum Is0 = new("stroke-0");
    public static readonly StrokeWidthEnum Is1 = new("stroke-1");
    public static readonly StrokeWidthEnum Is2 = new("stroke-2");
}
