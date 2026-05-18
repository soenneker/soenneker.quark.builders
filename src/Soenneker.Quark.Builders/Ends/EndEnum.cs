using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class EndEnum
{
    public static readonly EndEnum Is0 = new("end-0");
    public static readonly EndEnum Is1 = new("end-1");
    public static readonly EndEnum Is1_5 = new("end-1.5");
    public static readonly EndEnum Is2 = new("end-2");
    public static readonly EndEnum Is3 = new("end-3");
    public static readonly EndEnum Is4 = new("end-4");
    public static readonly EndEnum Is5 = new("end-5");
    public static readonly EndEnum Auto = new("end-auto");
    public static readonly EndEnum Px = new("end-px");
}
