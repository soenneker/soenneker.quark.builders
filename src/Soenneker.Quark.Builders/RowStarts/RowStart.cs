namespace Soenneker.Quark;

public static class RowStart
{
    public static RowStartBuilder Auto => new("auto");
    public static RowStartBuilder At(int value) => new(value.ToString());
    public static RowStartBuilder Token(string value) => new(value);
}
