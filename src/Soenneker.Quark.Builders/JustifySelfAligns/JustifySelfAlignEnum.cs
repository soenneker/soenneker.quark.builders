using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class JustifySelfAlignEnum
{
    public static readonly JustifySelfAlignEnum Auto = new("justify-self-auto");
    public static readonly JustifySelfAlignEnum Start = new("justify-self-start");
    public static readonly JustifySelfAlignEnum End = new("justify-self-end");
    public static readonly JustifySelfAlignEnum Center = new("justify-self-center");
    public static readonly JustifySelfAlignEnum Stretch = new("justify-self-stretch");
}
