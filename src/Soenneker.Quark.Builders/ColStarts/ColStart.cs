namespace Soenneker.Quark;

public static class ColStart
{
    public static ColStartBuilder Auto => new("auto");
    public static ColStartBuilder At(int value) => new(value.ToString());
    public static ColStartBuilder Token(string value) => new(value);
}
