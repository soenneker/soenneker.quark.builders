namespace Soenneker.Quark;

public static class AutoRows
{
    public static AutoRowsBuilder Auto => new("auto");
    public static AutoRowsBuilder Min => new("min");
    public static AutoRowsBuilder Max => new("max");
    public static AutoRowsBuilder Fr => new("fr");
    public static AutoRowsBuilder Token(string value) => new(value);
}
