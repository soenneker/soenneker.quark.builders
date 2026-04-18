using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class GrowEnum
{
    public static readonly GrowEnum Is1 = new("grow");
    public static readonly GrowEnum Is0 = new("grow-0");
}
