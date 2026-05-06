using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ScrollPaddingScaleEnum
{
    public static readonly ScrollPaddingScaleEnum Is0 = new("scroll-p-0");
    public static readonly ScrollPaddingScaleEnum Is1 = new("scroll-p-1");
    public static readonly ScrollPaddingScaleEnum Is2 = new("scroll-p-2");
    public static readonly ScrollPaddingScaleEnum Is3 = new("scroll-p-3");
    public static readonly ScrollPaddingScaleEnum Is4 = new("scroll-p-4");
    public static readonly ScrollPaddingScaleEnum Is5 = new("scroll-p-5");
    public static readonly ScrollPaddingScaleEnum Px = new("scroll-p-px");
}
