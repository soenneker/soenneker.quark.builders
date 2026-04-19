namespace Soenneker.Quark;

public static class GridCols
{
    public static GridColsBuilder Is1 => new("grid-cols-1");
    public static GridColsBuilder Is2 => new("grid-cols-2");
    public static GridColsBuilder Is3 => new("grid-cols-3");
    public static GridColsBuilder Is4 => new("grid-cols-4");
    public static GridColsBuilder Is5 => new("grid-cols-5");
    public static GridColsBuilder Is6 => new("grid-cols-6");
    public static GridColsBuilder Is7 => new("grid-cols-7");
    public static GridColsBuilder Is8 => new("grid-cols-8");
    public static GridColsBuilder Is9 => new("grid-cols-9");
    public static GridColsBuilder Is10 => new("grid-cols-10");
    public static GridColsBuilder Is11 => new("grid-cols-11");
    public static GridColsBuilder Is12 => new("grid-cols-12");
    public static GridColsBuilder None => new("grid-cols-none");
    public static GridColsBuilder Subgrid => new("grid-cols-subgrid");
    public static GridColsBuilder Count(int value) => new(value.ToString());
    public static GridColsBuilder Token(string value) => new("grid-cols-" + value);
}
