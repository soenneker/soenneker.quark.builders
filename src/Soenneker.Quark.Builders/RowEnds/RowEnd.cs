namespace Soenneker.Quark;

public static class RowEnd
{
    public static RowEndBuilder Auto => new("auto");
    public static RowEndBuilder At(int value) => new(value.ToString());
    public static RowEndBuilder Token(string value) => new(value);
}
