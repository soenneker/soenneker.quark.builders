namespace Soenneker.Quark;

public static class Column
{
    public static ColumnBuilder Is1 => new ColumnBuilder("1").Is1;
    public static ColumnBuilder Is2 => new ColumnBuilder("2").Is2;
    public static ColumnBuilder Is3 => new ColumnBuilder("3").Is3;
    public static ColumnBuilder Is4 => new ColumnBuilder("4").Is4;
    public static ColumnBuilder Is5 => new ColumnBuilder("5").Is5;
    public static ColumnBuilder Is6 => new ColumnBuilder("6").Is6;
    public static ColumnBuilder Is7 => new ColumnBuilder("7").Is7;
    public static ColumnBuilder Is8 => new ColumnBuilder("8").Is8;
    public static ColumnBuilder Is9 => new ColumnBuilder("9").Is9;
    public static ColumnBuilder Is10 => new ColumnBuilder("10").Is10;
    public static ColumnBuilder Is11 => new ColumnBuilder("11").Is11;
    public static ColumnBuilder Is12 => new ColumnBuilder("12").Is12;
    public static ColumnBuilder None => new ColumnBuilder("none").None;
    public static ColumnBuilder Subgrid => new ColumnBuilder("subgrid").Subgrid;
    public static ColumnBuilder Count(int value) => new ColumnBuilder(value.ToString()).Count(value);
    public static ColumnBuilder Token(string value) => new ColumnBuilder(value);
}
