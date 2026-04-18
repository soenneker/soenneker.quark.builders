using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ContentEnum
{
    public static readonly ContentEnum Normal = new("normal");
    public static readonly ContentEnum Center = new("center");
    public static readonly ContentEnum Start = new("start");
    public static readonly ContentEnum End = new("end");
    public static readonly ContentEnum Between = new("between");
    public static readonly ContentEnum Around = new("around");
    public static readonly ContentEnum Evenly = new("evenly");
    public static readonly ContentEnum Stretch = new("stretch");
    public static readonly ContentEnum Baseline = new("baseline");
}
