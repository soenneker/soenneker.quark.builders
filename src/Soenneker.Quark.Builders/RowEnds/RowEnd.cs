namespace Soenneker.Quark;

[TailwindModifiers(typeof(RowEndBuilder))]
public static partial class RowEnd
{
    public static RowEndBuilder Auto => new("row-end-auto");
    public static RowEndBuilder At(int value) => new(value.ToString());
    public static RowEndBuilder Token(string value) => new("row-end-" + value);
}
