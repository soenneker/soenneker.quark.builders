namespace Soenneker.Quark;

/// <summary>
/// Creates flex-direction utilities without changing display. Set Display.Flex or Display.InlineFlex separately.
/// </summary>
[TailwindModifiers(typeof(FlexDirectionBuilder))]
public static partial class FlexDirection
{
    /// <summary>
    /// Gets or sets row.
    /// </summary>
    public static FlexDirectionBuilder Row => new(FlexDirectionEnum.Row);
    /// <summary>
    /// Gets or sets row reverse.
    /// </summary>
    public static FlexDirectionBuilder RowReverse => new(FlexDirectionEnum.RowReverse);
    /// <summary>
    /// Gets or sets col.
    /// </summary>
    public static FlexDirectionBuilder Col => new(FlexDirectionEnum.Col);
    /// <summary>
    /// Gets or sets col reverse.
    /// </summary>
    public static FlexDirectionBuilder ColReverse => new(FlexDirectionEnum.ColReverse);
    /// <summary>
    /// Adds an arbitrary flex direction utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FlexDirectionBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "flex-"));
}
