namespace Soenneker.Quark;

public static class GridRows
{
    public static GridRowsBuilder Is1 => new("1");
    public static GridRowsBuilder Is2 => new("2");
    public static GridRowsBuilder Is3 => new("3");
    public static GridRowsBuilder Is4 => new("4");
    public static GridRowsBuilder Is5 => new("5");
    public static GridRowsBuilder Is6 => new("6");
    public static GridRowsBuilder None => new("none");
    public static GridRowsBuilder Subgrid => new("subgrid");
    public static GridRowsBuilder Count(int value) => new(value.ToString());
    public static GridRowsBuilder Token(string value) => new(value);
}
