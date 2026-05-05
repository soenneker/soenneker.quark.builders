namespace Soenneker.Quark;

/// <summary>
/// Static utility for bottom (bottom offset). Tailwind: bottom-*.
/// </summary>
public static class Bottom
{
    public static BottomBuilder Is0 => new(BottomEnum.Is0);
    public static BottomBuilder Is1 => new(BottomEnum.Is1);
    public static BottomBuilder Is2 => new(BottomEnum.Is2);
    public static BottomBuilder Is3 => new(BottomEnum.Is3);
    public static BottomBuilder Is4 => new(BottomEnum.Is4);
    public static BottomBuilder Is5 => new(BottomEnum.Is5);
    public static BottomBuilder Auto => new(BottomEnum.Auto);
    public static BottomBuilder Px => new(BottomEnum.Px);
    public static BottomBuilder Token(string value) => new(value.StartsWith("bottom-") ? value : "bottom-" + value);
}
