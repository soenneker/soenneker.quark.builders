using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class PointerEventsEnum
{
    public static readonly PointerEventsEnum None = new("pointer-events-none");
    public static readonly PointerEventsEnum Auto = new("pointer-events-auto");
}
