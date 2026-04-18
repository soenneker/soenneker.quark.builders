namespace Soenneker.Quark;

public static class ColEnd
{
    public static ColEndBuilder Auto => new("auto");
    public static ColEndBuilder At(int value) => new(value.ToString());
    public static ColEndBuilder Token(string value) => new(value);
}
