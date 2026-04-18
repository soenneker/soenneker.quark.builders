namespace Soenneker.Quark;

public static class AutoCols
{
    public static AutoColsBuilder Auto => new("auto");
    public static AutoColsBuilder Min => new("min");
    public static AutoColsBuilder Max => new("max");
    public static AutoColsBuilder Fr => new("fr");
    public static AutoColsBuilder Token(string value) => new(value);
}
