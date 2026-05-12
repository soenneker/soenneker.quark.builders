namespace Soenneker.Quark;

[TailwindModifiers(typeof(DecorationStyleBuilder))]
public static partial class DecorationStyle
{
    public static DecorationStyleBuilder Solid => new(DecorationStyleEnum.Solid);
    public static DecorationStyleBuilder Double => new(DecorationStyleEnum.Double);
    public static DecorationStyleBuilder Dotted => new(DecorationStyleEnum.Dotted);
    public static DecorationStyleBuilder Dashed => new(DecorationStyleEnum.Dashed);
    public static DecorationStyleBuilder Wavy => new(DecorationStyleEnum.Wavy);
    public static DecorationStyleBuilder Token(string value) => new("decoration-" + value);
}
