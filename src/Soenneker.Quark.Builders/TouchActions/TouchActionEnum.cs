using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TouchActionEnum
{
    public static readonly TouchActionEnum Auto = new("touch-auto");
    public static readonly TouchActionEnum None = new("touch-none");
    public static readonly TouchActionEnum PanX = new("touch-pan-x");
    public static readonly TouchActionEnum PanY = new("touch-pan-y");
    public static readonly TouchActionEnum Manipulation = new("touch-manipulation");
}
