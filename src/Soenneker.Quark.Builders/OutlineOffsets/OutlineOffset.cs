namespace Soenneker.Quark;

/// <summary>
/// Represents the outline offset.
/// </summary>
[TailwindModifiers(typeof(OutlineOffsetBuilder))]
public static partial class OutlineOffset
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static OutlineOffsetBuilder Is0 => new(OutlineOffsetEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static OutlineOffsetBuilder Is1 => new(OutlineOffsetEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static OutlineOffsetBuilder Is2 => new(OutlineOffsetEnum.Is2);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static OutlineOffsetBuilder Is4 => new(OutlineOffsetEnum.Is4);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static OutlineOffsetBuilder Is8 => new(OutlineOffsetEnum.Is8);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static OutlineOffsetBuilder Token(string value) => new("outline-offset-" + value);
}
