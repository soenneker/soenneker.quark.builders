using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RingEnum
{
    public static readonly RingEnum Default = new("ring");
    public static readonly RingEnum None = new("ring-0");
    public static readonly RingEnum Is1 = new("ring-1");
    public static readonly RingEnum Is2 = new("ring-2");
    public static readonly RingEnum Is4 = new("ring-4");
    public static readonly RingEnum Is8 = new("ring-8");
    public static readonly RingEnum Inset = new("ring-inset");
}
