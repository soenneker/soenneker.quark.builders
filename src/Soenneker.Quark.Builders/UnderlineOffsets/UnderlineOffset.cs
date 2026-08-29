namespace Soenneker.Quark;

/// <summary>
/// Represents the underline offset.
/// </summary>
[TailwindModifiers(typeof(UnderlineOffsetBuilder))]
public static partial class UnderlineOffset
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static UnderlineOffsetBuilder Auto => new(UnderlineOffsetEnum.Auto);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static UnderlineOffsetBuilder Is0 => new(UnderlineOffsetEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static UnderlineOffsetBuilder Is1 => new(UnderlineOffsetEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static UnderlineOffsetBuilder Is2 => new(UnderlineOffsetEnum.Is2);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static UnderlineOffsetBuilder Is4 => new(UnderlineOffsetEnum.Is4);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static UnderlineOffsetBuilder Is8 => new(UnderlineOffsetEnum.Is8);
    /// <summary>
    /// Adds an arbitrary underline offset utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static UnderlineOffsetBuilder Token(string value) => new("underline-offset-" + value);
}
