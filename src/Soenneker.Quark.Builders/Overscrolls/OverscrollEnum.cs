using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class OverscrollEnum
{
    public static readonly OverscrollEnum Auto = new("overscroll-auto");
    public static readonly OverscrollEnum Contain = new("overscroll-contain");
    public static readonly OverscrollEnum None = new("overscroll-none");
    public static readonly OverscrollEnum XAuto = new("overscroll-x-auto");
    public static readonly OverscrollEnum XContain = new("overscroll-x-contain");
    public static readonly OverscrollEnum XNone = new("overscroll-x-none");
    public static readonly OverscrollEnum YAuto = new("overscroll-y-auto");
    public static readonly OverscrollEnum YContain = new("overscroll-y-contain");
    public static readonly OverscrollEnum YNone = new("overscroll-y-none");
}
