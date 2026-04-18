using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RingEnum
{
    public static readonly RingEnum Default = new("ring");
    public static readonly RingEnum None = new("ring-0");
    public static readonly RingEnum One = new("ring-1");
    public static readonly RingEnum Two = new("ring-2");
    public static readonly RingEnum Four = new("ring-4");
    public static readonly RingEnum Eight = new("ring-8");
    public static readonly RingEnum Inset = new("ring-inset");
}
