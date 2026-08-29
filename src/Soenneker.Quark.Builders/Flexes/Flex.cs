namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility. Tailwind: flex-1, flex-auto, flex-initial, flex-none, flex-wrap, flex-row, flex-col.
/// </summary>
[TailwindModifiers(typeof(FlexBuilder))]
public static partial class Flex
{
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static FlexBuilder Is1 => new(FlexEnum.Is1);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static FlexBuilder Auto => new(FlexEnum.Auto);
    /// <summary>
    /// Gets or sets initial.
    /// </summary>
    public static FlexBuilder Initial => new(FlexEnum.Initial);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static FlexBuilder None => new(FlexEnum.None);
    /// <summary>
    /// Gets or sets wrap.
    /// </summary>
    public static FlexBuilder Wrap => new(FlexEnum.Wrap);
    /// <summary>
    /// Gets or sets wrap reverse.
    /// </summary>
    public static FlexBuilder WrapReverse => new(FlexEnum.WrapReverse);
    /// <summary>
    /// Gets or sets no wrap.
    /// </summary>
    public static FlexBuilder NoWrap => new(FlexEnum.NoWrap);
    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public static FlexBuilder Row => new(FlexEnum.Row);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public static FlexBuilder RowReverse => new(FlexEnum.RowReverse);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public static FlexBuilder Col => new(FlexEnum.Col);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public static FlexBuilder ColReverse => new(FlexEnum.ColReverse);
    /// <summary>
    /// Adds an arbitrary flex utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FlexBuilder Token(string value) => new($"flex-{value}");
}
