using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class DecorationThicknessEnum
{
    public static readonly DecorationThicknessEnum Auto = new("decoration-auto");
    public static readonly DecorationThicknessEnum FromFont = new("decoration-from-font");
    public static readonly DecorationThicknessEnum Is0 = new("decoration-0");
    public static readonly DecorationThicknessEnum Is1 = new("decoration-1");
    public static readonly DecorationThicknessEnum Is2 = new("decoration-2");
    public static readonly DecorationThicknessEnum Is4 = new("decoration-4");
    public static readonly DecorationThicknessEnum Is8 = new("decoration-8");
}
