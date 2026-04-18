using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class SelfEnum
{
    public static readonly SelfEnum Auto = new("auto");
    public static readonly SelfEnum Start = new("start");
    public static readonly SelfEnum End = new("end");
    public static readonly SelfEnum Center = new("center");
    public static readonly SelfEnum Stretch = new("stretch");
    public static readonly SelfEnum Baseline = new("baseline");
}
