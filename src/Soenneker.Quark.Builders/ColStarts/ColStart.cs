namespace Soenneker.Quark;

public static class ColStart
{
    public static ColStartBuilder Auto => new("col-start-auto");
    public static ColStartBuilder At(int value) => new(value.ToString());
    public static ColStartBuilder Token(string value) => new("col-start-" + value);
}
