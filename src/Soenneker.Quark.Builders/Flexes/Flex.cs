
namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility. Tailwind: flex-1, flex-auto, flex-initial, flex-none, flex-wrap, flex-row, flex-col.
/// </summary>
public static class Flex
{
    public static FlexBuilder Is1 => new(FlexEnum.Is1);
    public static FlexBuilder Auto => new(FlexEnum.Auto);
    public static FlexBuilder Initial => new(FlexEnum.Initial);
    public static FlexBuilder None => new(FlexEnum.None);
    public static FlexBuilder Wrap => new(FlexEnum.Wrap);
    public static FlexBuilder WrapReverse => new(FlexEnum.WrapReverse);
    public static FlexBuilder NoWrap => new(FlexEnum.NoWrap);
    public static FlexBuilder Row => new(FlexEnum.Row);
    public static FlexBuilder RowReverse => new(FlexEnum.RowReverse);
    public static FlexBuilder Col => new(FlexEnum.Col);
    public static FlexBuilder ColReverse => new(FlexEnum.ColReverse);
    public static FlexBuilder Token(string value) => new($"flex-{value}");
}
