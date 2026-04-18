using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ShrinkEnum
{
    public static readonly ShrinkEnum Is1 = new("shrink");
    public static readonly ShrinkEnum Is0 = new("shrink-0");
}
