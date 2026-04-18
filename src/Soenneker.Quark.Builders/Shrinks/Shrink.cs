namespace Soenneker.Quark;

public static class Shrink
{
    public static ShrinkBuilder Is1 => new(ShrinkEnum.Is1);
    public static ShrinkBuilder Is0 => new(ShrinkEnum.Is0);
    public static ShrinkBuilder Token(string value) => new(value);
}
