using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class SelfEnum
{
    public static readonly SelfEnum Auto = new("self-auto");
    public static readonly SelfEnum Start = new("self-start");
    public static readonly SelfEnum End = new("self-end");
    public static readonly SelfEnum Center = new("self-center");
    public static readonly SelfEnum Stretch = new("self-stretch");
    public static readonly SelfEnum Baseline = new("self-baseline");
}
