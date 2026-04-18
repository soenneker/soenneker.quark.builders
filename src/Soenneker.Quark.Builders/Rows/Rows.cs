namespace Soenneker.Quark;

public static class Rows
{
    public static RowBuilder Is1 => Row.Is1;
    public static RowBuilder Is2 => Row.Is2;
    public static RowBuilder Is3 => Row.Is3;
    public static RowBuilder Is4 => Row.Is4;
    public static RowBuilder Is5 => Row.Is5;
    public static RowBuilder Is6 => Row.Is6;
    public static RowBuilder None => Row.None;
    public static RowBuilder Subgrid => Row.Subgrid;
    public static RowBuilder Count(int value) => Row.Count(value);
    public static RowBuilder Token(string value) => Row.Token(value);
}
