namespace Soenneker.Quark;

/// <summary>
/// Static utility for right (right offset). Tailwind: right-*.
/// </summary>
public static class Right
{
    public static RightBuilder Is0 => new(RightEnum.Is0);
    public static RightBuilder Is1 => new(RightEnum.Is1);
    public static RightBuilder Is2 => new(RightEnum.Is2);
    public static RightBuilder Is3 => new(RightEnum.Is3);
    public static RightBuilder Is4 => new(RightEnum.Is4);
    public static RightBuilder Is5 => new(RightEnum.Is5);
    public static RightBuilder Auto => new(RightEnum.Auto);
    public static RightBuilder Px => new(RightEnum.Px);
    public static RightBuilder Token(string value) => new(value.StartsWith("right-") ? value : "right-" + value);
}
