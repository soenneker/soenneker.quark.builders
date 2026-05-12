namespace Soenneker.Quark;

[TailwindModifiers(typeof(ColStartBuilder))]
public static partial class ColStart
{
    public static ColStartBuilder Is1 => new("col-start-1");
    public static ColStartBuilder Is2 => new("col-start-2");
    public static ColStartBuilder Auto => new("col-start-auto");
    public static ColStartBuilder At(int value) => new(value.ToString());
    public static ColStartBuilder Token(string value) => new("col-start-" + value);
}
