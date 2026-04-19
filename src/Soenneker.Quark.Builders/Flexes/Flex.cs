
namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility. Tailwind: flex-1, flex-auto, flex-initial, flex-none.
/// </summary>
public static class Flex
{
    public static FlexBuilder Is1 => new(FlexEnum.Is1);
    public static FlexBuilder Auto => new(FlexEnum.Auto);
    public static FlexBuilder Initial => new(FlexEnum.Initial);
    public static FlexBuilder None => new(FlexEnum.None);
    public static FlexBuilder Token(string value) => new($"flex-{value}");
}
