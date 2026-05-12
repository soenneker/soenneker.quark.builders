using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BottomEnum
{
    public static readonly BottomEnum Is0 = new("bottom-0");
    public static readonly BottomEnum Is1 = new("bottom-1");
    public static readonly BottomEnum Is2 = new("bottom-2");
    public static readonly BottomEnum Is3 = new("bottom-3");
    public static readonly BottomEnum Is4 = new("bottom-4");
    public static readonly BottomEnum Is5 = new("bottom-5");
    public static readonly BottomEnum Is6 = new("bottom-6");
    public static readonly BottomEnum Is8 = new("bottom-8");
    public static readonly BottomEnum Is12 = new("bottom-12");
    public static readonly BottomEnum Is16 = new("bottom-16");
    public static readonly BottomEnum Is24 = new("bottom-24");
    public static readonly BottomEnum Auto = new("bottom-auto");
    public static readonly BottomEnum Px = new("bottom-px");
    public static readonly BottomEnum Negative1 = new("-bottom-1");
}
