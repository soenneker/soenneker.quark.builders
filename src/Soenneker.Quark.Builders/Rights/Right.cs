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
    public static RightBuilder Is0 => new(RightEnum.Is0Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static RightBuilder Is1 => new(RightEnum.Is1Value);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static RightBuilder Is1_5 => new(RightEnum.Is1_5Value);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static RightBuilder Is2 => new(RightEnum.Is2Value);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static RightBuilder Is3 => new(RightEnum.Is3Value);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static RightBuilder Is4 => new(RightEnum.Is4Value);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static RightBuilder Is5 => new(RightEnum.Is5Value);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static RightBuilder Is8 => new(RightEnum.Is8Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static RightBuilder Is12 => new(RightEnum.Is12Value);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public static RightBuilder Is16 => new(RightEnum.Is16Value);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public static RightBuilder Is24 => new(RightEnum.Is24Value);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static RightBuilder Auto => new(RightEnum.AutoValue);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public static RightBuilder Px => new(RightEnum.PxValue);
    /// <summary>
    /// Adds an arbitrary right utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static RightBuilder Token(string value) => new(value.StartsWith("right-") ? value : "right-" + value);
}
