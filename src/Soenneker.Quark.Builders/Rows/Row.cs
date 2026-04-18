namespace Soenneker.Quark;

public static class Row
{
    public static RowBuilder Is1 => new RowBuilder("1").Is1;
    public static RowBuilder Is2 => new RowBuilder("2").Is2;
    public static RowBuilder Is3 => new RowBuilder("3").Is3;
    public static RowBuilder Is4 => new RowBuilder("4").Is4;
    public static RowBuilder Is5 => new RowBuilder("5").Is5;
    public static RowBuilder Is6 => new RowBuilder("6").Is6;
    public static RowBuilder None => new RowBuilder("none").None;
    public static RowBuilder Subgrid => new RowBuilder("subgrid").Subgrid;
    public static RowBuilder Count(int value) => new RowBuilder(value.ToString()).Count(value);
    public static RowBuilder Token(string value) => new RowBuilder(value);
}
