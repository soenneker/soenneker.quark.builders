using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScrollSnapAlignEnum
{
    public static readonly ScrollSnapAlignEnum Start = new("snap-start");
    public static readonly ScrollSnapAlignEnum Center = new("snap-center");
    public static readonly ScrollSnapAlignEnum End = new("snap-end");
    public static readonly ScrollSnapAlignEnum None = new("snap-align-none");
}
