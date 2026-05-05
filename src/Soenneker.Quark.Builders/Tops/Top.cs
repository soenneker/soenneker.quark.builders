namespace Soenneker.Quark;

/// <summary>
/// Static utility for top (top offset). Tailwind: top-*.
/// </summary>
public static class Top
{
    public static TopBuilder Is0 => new(TopEnum.Is0);
    public static TopBuilder Is1 => new(TopEnum.Is1);
    public static TopBuilder Is2 => new(TopEnum.Is2);
    public static TopBuilder Is3 => new(TopEnum.Is3);
    public static TopBuilder Is4 => new(TopEnum.Is4);
    public static TopBuilder Is5 => new(TopEnum.Is5);
    public static TopBuilder Is8 => new(TopEnum.Is8);
    public static TopBuilder Is12 => new(TopEnum.Is12);
    public static TopBuilder Is16 => new(TopEnum.Is16);
    public static TopBuilder Is24 => new(TopEnum.Is24);
    public static TopBuilder Auto => new(TopEnum.Auto);
    public static TopBuilder Px => new(TopEnum.Px);
    public static TopBuilder Token(string value) => new(value.StartsWith("top-") ? value : "top-" + value);
}
