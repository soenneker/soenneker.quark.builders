using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScrollSnapEnum
{
    public static readonly ScrollSnapEnum None = new("snap-none");
    public static readonly ScrollSnapEnum X = new("snap-x");
    public static readonly ScrollSnapEnum Y = new("snap-y");
    public static readonly ScrollSnapEnum Both = new("snap-both");
    public static readonly ScrollSnapEnum Mandatory = new("snap-mandatory");
    public static readonly ScrollSnapEnum Proximity = new("snap-proximity");
}
