using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DecorationThicknessEnum
{
    public static readonly DecorationThicknessEnum Auto = new("auto");
    public static readonly DecorationThicknessEnum FromFont = new("from-font");
    public static readonly DecorationThicknessEnum Is0 = new("0");
    public static readonly DecorationThicknessEnum Is1 = new("1");
    public static readonly DecorationThicknessEnum Is2 = new("2");
    public static readonly DecorationThicknessEnum Is4 = new("4");
    public static readonly DecorationThicknessEnum Is8 = new("8");
}
