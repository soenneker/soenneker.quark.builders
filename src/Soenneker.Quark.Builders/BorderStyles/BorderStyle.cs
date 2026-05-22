namespace Soenneker.Quark;

[TailwindModifiers(typeof(BorderStyleBuilder))]
public static partial class BorderStyle
{
    public static BorderStyleBuilder Solid => new(BorderStyleEnum.Solid);
    public static BorderStyleBuilder Dashed => new(BorderStyleEnum.Dashed);
    public static BorderStyleBuilder Dotted => new(BorderStyleEnum.Dotted);
    public static BorderStyleBuilder Double => new(BorderStyleEnum.Double);
    public static BorderStyleBuilder Hidden => new(BorderStyleEnum.Hidden);
    public static BorderStyleBuilder None => new(BorderStyleEnum.None);
    public static BorderStyleBuilder Token(string value) => new(value.StartsWith("border-") ? value : $"border-{value}");
}
