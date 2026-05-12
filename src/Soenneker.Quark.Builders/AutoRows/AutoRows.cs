namespace Soenneker.Quark;

[TailwindModifiers(typeof(AutoRowsBuilder))]
public static partial class AutoRows
{
    public static AutoRowsBuilder Auto => new(AutoRowsEnum.Auto);
    public static AutoRowsBuilder Min => new(AutoRowsEnum.Min);
    public static AutoRowsBuilder Max => new(AutoRowsEnum.Max);
    public static AutoRowsBuilder Fr => new(AutoRowsEnum.Fr);
    public static AutoRowsBuilder Token(string value) => new($"auto-rows-{value}");
}
