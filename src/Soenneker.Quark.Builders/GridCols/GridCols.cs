namespace Soenneker.Quark;

public static class GridCols
{
    public static GridColsBuilder Is1 => new("1");
    public static GridColsBuilder Is2 => new("2");
    public static GridColsBuilder Is3 => new("3");
    public static GridColsBuilder Is4 => new("4");
    public static GridColsBuilder Is5 => new("5");
    public static GridColsBuilder Is6 => new("6");
    public static GridColsBuilder Is7 => new("7");
    public static GridColsBuilder Is8 => new("8");
    public static GridColsBuilder Is9 => new("9");
    public static GridColsBuilder Is10 => new("10");
    public static GridColsBuilder Is11 => new("11");
    public static GridColsBuilder Is12 => new("12");
    public static GridColsBuilder None => new("none");
    public static GridColsBuilder Subgrid => new("subgrid");
    public static GridColsBuilder Count(int value) => new(value.ToString());
    public static GridColsBuilder Token(string value) => new(value);
}
