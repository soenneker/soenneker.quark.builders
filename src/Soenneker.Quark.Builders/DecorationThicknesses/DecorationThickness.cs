namespace Soenneker.Quark;

public static class DecorationThickness
{
    public static DecorationThicknessBuilder Auto => new(DecorationThicknessEnum.Auto);
    public static DecorationThicknessBuilder FromFont => new(DecorationThicknessEnum.FromFont);
    public static DecorationThicknessBuilder Is0 => new(DecorationThicknessEnum.Is0);
    public static DecorationThicknessBuilder Is1 => new(DecorationThicknessEnum.Is1);
    public static DecorationThicknessBuilder Is2 => new(DecorationThicknessEnum.Is2);
    public static DecorationThicknessBuilder Is4 => new(DecorationThicknessEnum.Is4);
    public static DecorationThicknessBuilder Is8 => new(DecorationThicknessEnum.Is8);
    public static DecorationThicknessBuilder Token(string value) => new("decoration-" + value);
}
