using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ContentEnum
{
    public static readonly ContentEnum Normal = new("content-normal");
    public static readonly ContentEnum Center = new("content-center");
    public static readonly ContentEnum Start = new("content-start");
    public static readonly ContentEnum End = new("content-end");
    public static readonly ContentEnum Between = new("content-between");
    public static readonly ContentEnum Around = new("content-around");
    public static readonly ContentEnum Evenly = new("content-evenly");
    public static readonly ContentEnum Stretch = new("content-stretch");
    public static readonly ContentEnum Baseline = new("content-baseline");
}
