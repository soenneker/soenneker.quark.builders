namespace Soenneker.Quark;

public static class GridRows
{
    public static GridRowsBuilder Is1 => new("grid-rows-1");
    public static GridRowsBuilder Is2 => new("grid-rows-2");
    public static GridRowsBuilder Is3 => new("grid-rows-3");
    public static GridRowsBuilder Is4 => new("grid-rows-4");
    public static GridRowsBuilder Is5 => new("grid-rows-5");
    public static GridRowsBuilder Is6 => new("grid-rows-6");
    public static GridRowsBuilder None => new("grid-rows-none");
    public static GridRowsBuilder Subgrid => new("grid-rows-subgrid");
    public static GridRowsBuilder Count(int value) => new("grid-rows-" + value);
    public static GridRowsBuilder Token(string value) => new("grid-rows-" + value);
}
