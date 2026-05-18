namespace Soenneker.Quark;

/// <summary>
/// Static utility for right (right offset). Tailwind: right-*.
/// </summary>
[TailwindModifiers(typeof(RightBuilder))]
public static partial class Right
{
    public static RightBuilder Is0 => new(RightEnum.Is0);
    public static RightBuilder Is1 => new(RightEnum.Is1);
    public static RightBuilder Is1_5 => new(RightEnum.Is1_5);
    public static RightBuilder Is2 => new(RightEnum.Is2);
    public static RightBuilder Is3 => new(RightEnum.Is3);
    public static RightBuilder Is4 => new(RightEnum.Is4);
    public static RightBuilder Is5 => new(RightEnum.Is5);
    public static RightBuilder Is8 => new(RightEnum.Is8);
    public static RightBuilder Is12 => new(RightEnum.Is12);
    public static RightBuilder Is16 => new(RightEnum.Is16);
    public static RightBuilder Is24 => new(RightEnum.Is24);
    public static RightBuilder Auto => new(RightEnum.Auto);
    public static RightBuilder Px => new(RightEnum.Px);
    public static RightBuilder Token(string value) => new(value.StartsWith("right-") ? value : "right-" + value);
}
