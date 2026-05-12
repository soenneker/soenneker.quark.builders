namespace Soenneker.Quark;

[TailwindModifiers(typeof(AutoColsBuilder))]
public static partial class AutoCols
{
    public static AutoColsBuilder Auto => new(AutoColsEnum.Auto);
    public static AutoColsBuilder Min => new(AutoColsEnum.Min);
    public static AutoColsBuilder Max => new(AutoColsEnum.Max);
    public static AutoColsBuilder Fr => new(AutoColsEnum.Fr);
    public static AutoColsBuilder Token(string value) => new($"auto-cols-{value}");
}