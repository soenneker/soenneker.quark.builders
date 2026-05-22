namespace Soenneker.Quark;

[TailwindModifiers(typeof(OverflowWrapBuilder))]
public static partial class OverflowWrap
{
    public static OverflowWrapBuilder Normal => new(OverflowWrapEnum.Normal);
    public static OverflowWrapBuilder Anywhere => new(OverflowWrapEnum.Anywhere);
    public static OverflowWrapBuilder BreakWord => new(OverflowWrapEnum.BreakWord);
    public static OverflowWrapBuilder Token(string value) => new(value.StartsWith("wrap-") ? value : $"wrap-{value}");
}
