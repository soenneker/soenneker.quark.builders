using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TopEnum
{
    public static readonly TopEnum Is0 = new("top-0");
    public static readonly TopEnum Is1 = new("top-1");
    public static readonly TopEnum Is2 = new("top-2");
    public static readonly TopEnum Is3 = new("top-3");
    public static readonly TopEnum Is4 = new("top-4");
    public static readonly TopEnum Is5 = new("top-5");
    public static readonly TopEnum Auto = new("top-auto");
    public static readonly TopEnum Px = new("top-px");
}
