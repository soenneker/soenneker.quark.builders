using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TopEnum
{
    public static readonly TopEnum Is0 = new("top-0");
    public static readonly TopEnum Is1 = new("top-1");
    public static readonly TopEnum Is1_5 = new("top-1.5");
    public static readonly TopEnum Is1of2 = new("top-1/2");
    public static readonly TopEnum Is1of3 = new("top-1/3");
    public static readonly TopEnum Is2 = new("top-2");
    public static readonly TopEnum Is3 = new("top-3");
    public static readonly TopEnum Is4 = new("top-4");
    public static readonly TopEnum Is5 = new("top-5");
    public static readonly TopEnum Is8 = new("top-8");
    public static readonly TopEnum Is12 = new("top-12");
    public static readonly TopEnum Is16 = new("top-16");
    public static readonly TopEnum Is24 = new("top-24");
    public static readonly TopEnum Auto = new("top-auto");
    public static readonly TopEnum Px = new("top-px");
}
