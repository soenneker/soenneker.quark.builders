using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class WillChangeEnum
{
    public static readonly WillChangeEnum Auto = new("will-change-auto");
    public static readonly WillChangeEnum Scroll = new("will-change-scroll");
    public static readonly WillChangeEnum Contents = new("will-change-contents");
    public static readonly WillChangeEnum Transform = new("will-change-transform");
}
