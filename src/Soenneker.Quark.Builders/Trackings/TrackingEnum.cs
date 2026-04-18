using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TrackingEnum
{
    public static readonly TrackingEnum Tighter = new("tighter");
    public static readonly TrackingEnum Tight = new("tight");
    public static readonly TrackingEnum Normal = new("normal");
    public static readonly TrackingEnum Wide = new("wide");
    public static readonly TrackingEnum Wider = new("wider");
    public static readonly TrackingEnum Widest = new("widest");
}
