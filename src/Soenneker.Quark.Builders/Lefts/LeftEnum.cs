using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class LeftEnum
{
    public static readonly LeftEnum Is0 = new("left-0");
    public static readonly LeftEnum Is1 = new("left-1");
    public static readonly LeftEnum Is2 = new("left-2");
    public static readonly LeftEnum Is3 = new("left-3");
    public static readonly LeftEnum Is4 = new("left-4");
    public static readonly LeftEnum Is5 = new("left-5");
    public static readonly LeftEnum Is8 = new("left-8");
    public static readonly LeftEnum Is12 = new("left-12");
    public static readonly LeftEnum Is16 = new("left-16");
    public static readonly LeftEnum Is24 = new("left-24");
    public static readonly LeftEnum Auto = new("left-auto");
    public static readonly LeftEnum Px = new("left-px");
}
