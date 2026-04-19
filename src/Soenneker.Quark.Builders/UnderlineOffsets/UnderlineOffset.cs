namespace Soenneker.Quark;

public static class UnderlineOffset
{
    public static UnderlineOffsetBuilder Auto => new(UnderlineOffsetEnum.Auto);
    public static UnderlineOffsetBuilder Is0 => new(UnderlineOffsetEnum.Is0);
    public static UnderlineOffsetBuilder Is1 => new(UnderlineOffsetEnum.Is1);
    public static UnderlineOffsetBuilder Is2 => new(UnderlineOffsetEnum.Is2);
    public static UnderlineOffsetBuilder Is4 => new(UnderlineOffsetEnum.Is4);
    public static UnderlineOffsetBuilder Is8 => new(UnderlineOffsetEnum.Is8);
    public static UnderlineOffsetBuilder Token(string value) => new("underline-offset-" + value);
}
