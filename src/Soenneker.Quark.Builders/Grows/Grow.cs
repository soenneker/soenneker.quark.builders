namespace Soenneker.Quark;

public static class Grow
{
    public static GrowBuilder Is1 => new(GrowEnum.Is1);
    public static GrowBuilder Is0 => new(GrowEnum.Is0);
    public static GrowBuilder Token(string value) => new(value);
}
