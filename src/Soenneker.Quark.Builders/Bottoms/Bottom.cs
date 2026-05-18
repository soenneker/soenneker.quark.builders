namespace Soenneker.Quark;

/// <summary>
/// Static utility for bottom (bottom offset). Tailwind: bottom-*.
/// </summary>
[TailwindModifiers(typeof(BottomBuilder))]
public static partial class Bottom
{
    public static BottomBuilder Is0 => new(BottomEnum.Is0);
    public static BottomBuilder Is1 => new(BottomEnum.Is1);
    public static BottomBuilder Is1_5 => new(BottomEnum.Is1_5);
    public static BottomBuilder Is2 => new(BottomEnum.Is2);
    public static BottomBuilder Is3 => new(BottomEnum.Is3);
    public static BottomBuilder Is4 => new(BottomEnum.Is4);
    public static BottomBuilder Is5 => new(BottomEnum.Is5);
    public static BottomBuilder Is6 => new(BottomEnum.Is6);
    public static BottomBuilder Is8 => new(BottomEnum.Is8);
    public static BottomBuilder Is12 => new(BottomEnum.Is12);
    public static BottomBuilder Is16 => new(BottomEnum.Is16);
    public static BottomBuilder Is24 => new(BottomEnum.Is24);
    public static BottomBuilder Auto => new(BottomEnum.Auto);
    public static BottomBuilder Px => new(BottomEnum.Px);
    public static BottomBuilder Negative1 => new(BottomEnum.Negative1);
    public static BottomBuilder Token(string value) => new(value.StartsWith("bottom-") ? value : "bottom-" + value);
}
