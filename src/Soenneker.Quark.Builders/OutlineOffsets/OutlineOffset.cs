namespace Soenneker.Quark;

public static class OutlineOffset
{
    public static OutlineOffsetBuilder Is0 => new(OutlineOffsetEnum.Is0);
    public static OutlineOffsetBuilder Is1 => new(OutlineOffsetEnum.Is1);
    public static OutlineOffsetBuilder Is2 => new(OutlineOffsetEnum.Is2);
    public static OutlineOffsetBuilder Is4 => new(OutlineOffsetEnum.Is4);
    public static OutlineOffsetBuilder Is8 => new(OutlineOffsetEnum.Is8);
    public static OutlineOffsetBuilder Token(string value) => new(value);
}
