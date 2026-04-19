using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class JustifySelfAlignEnum
{
    public static readonly JustifySelfAlignEnum Auto = new("auto");
    public static readonly JustifySelfAlignEnum Start = new("start");
    public static readonly JustifySelfAlignEnum End = new("end");
    public static readonly JustifySelfAlignEnum Center = new("center");
    public static readonly JustifySelfAlignEnum Stretch = new("stretch");
}
