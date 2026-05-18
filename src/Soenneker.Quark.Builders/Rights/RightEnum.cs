using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class RightEnum
{
    public static readonly RightEnum Is0 = new("right-0");
    public static readonly RightEnum Is1 = new("right-1");
    public static readonly RightEnum Is1_5 = new("right-1.5");
    public static readonly RightEnum Is2 = new("right-2");
    public static readonly RightEnum Is3 = new("right-3");
    public static readonly RightEnum Is4 = new("right-4");
    public static readonly RightEnum Is5 = new("right-5");
    public static readonly RightEnum Is8 = new("right-8");
    public static readonly RightEnum Is12 = new("right-12");
    public static readonly RightEnum Is16 = new("right-16");
    public static readonly RightEnum Is24 = new("right-24");
    public static readonly RightEnum Auto = new("right-auto");
    public static readonly RightEnum Px = new("right-px");
}
