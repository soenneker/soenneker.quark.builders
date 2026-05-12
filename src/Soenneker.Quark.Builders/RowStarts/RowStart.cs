namespace Soenneker.Quark;

[TailwindModifiers(typeof(RowStartBuilder))]
public static partial class RowStart
{
    public static RowStartBuilder Auto => new("row-start-auto");
    public static RowStartBuilder At(int value) => new(value.ToString());
    public static RowStartBuilder Token(string value) => new("row-start-" + value);
}
