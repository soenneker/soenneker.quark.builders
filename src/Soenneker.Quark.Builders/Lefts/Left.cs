namespace Soenneker.Quark;

/// <summary>
/// Static utility for left (left offset). Tailwind: left-*.
/// </summary>
public static class Left
{
    public static LeftBuilder Is0 => new(LeftEnum.Is0);
    public static LeftBuilder Is1 => new(LeftEnum.Is1);
    public static LeftBuilder Is2 => new(LeftEnum.Is2);
    public static LeftBuilder Is3 => new(LeftEnum.Is3);
    public static LeftBuilder Is4 => new(LeftEnum.Is4);
    public static LeftBuilder Is5 => new(LeftEnum.Is5);
    public static LeftBuilder Is8 => new(LeftEnum.Is8);
    public static LeftBuilder Is12 => new(LeftEnum.Is12);
    public static LeftBuilder Is16 => new(LeftEnum.Is16);
    public static LeftBuilder Is24 => new(LeftEnum.Is24);
    public static LeftBuilder Auto => new(LeftEnum.Auto);
    public static LeftBuilder Px => new(LeftEnum.Px);
    public static LeftBuilder Token(string value) => new(value.StartsWith("left-") ? value : "left-" + value);
}
