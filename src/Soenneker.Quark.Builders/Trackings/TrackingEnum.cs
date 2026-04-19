using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TrackingEnum
{
    public static readonly TrackingEnum Tighter = new("tracking-tighter");
    public static readonly TrackingEnum Tight = new("tracking-tight");
    public static readonly TrackingEnum Normal = new("tracking-normal");
    public static readonly TrackingEnum Wide = new("tracking-wide");
    public static readonly TrackingEnum Wider = new("tracking-wider");
    public static readonly TrackingEnum Widest = new("tracking-widest");
}
