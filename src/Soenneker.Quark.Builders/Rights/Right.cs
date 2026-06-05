namespace Soenneker.Quark;

/// <summary>
/// Static utility for right (right offset). Tailwind: right-*.
/// </summary>
[TailwindModifiers(typeof(RightBuilder))]
public static partial class Right
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static RightBuilder Is0 => new(RightEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static RightBuilder Is1 => new(RightEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static RightBuilder Is1_5 => new(RightEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static RightBuilder Is2 => new(RightEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static RightBuilder Is3 => new(RightEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static RightBuilder Is4 => new(RightEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static RightBuilder Is5 => new(RightEnum.Is5);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static RightBuilder Is8 => new(RightEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static RightBuilder Is12 => new(RightEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public static RightBuilder Is16 => new(RightEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public static RightBuilder Is24 => new(RightEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static RightBuilder Auto => new(RightEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public static RightBuilder Px => new(RightEnum.Px);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RightBuilder Token(string value) => new(value.StartsWith("right-") ? value : "right-" + value);
}
