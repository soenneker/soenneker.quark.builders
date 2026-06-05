namespace Soenneker.Quark;

/// <summary>
/// Static utility for bottom (bottom offset). Tailwind: bottom-*.
/// </summary>
[TailwindModifiers(typeof(BottomBuilder))]
public static partial class Bottom
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static BottomBuilder Is0 => new(BottomEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static BottomBuilder Is1 => new(BottomEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static BottomBuilder Is1_5 => new(BottomEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static BottomBuilder Is2 => new(BottomEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static BottomBuilder Is3 => new(BottomEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static BottomBuilder Is4 => new(BottomEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static BottomBuilder Is5 => new(BottomEnum.Is5);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static BottomBuilder Is6 => new(BottomEnum.Is6);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static BottomBuilder Is8 => new(BottomEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static BottomBuilder Is12 => new(BottomEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public static BottomBuilder Is16 => new(BottomEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public static BottomBuilder Is24 => new(BottomEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static BottomBuilder Auto => new(BottomEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public static BottomBuilder Px => new(BottomEnum.Px);
    /// <summary>
    /// Gets or sets negative1.
    /// </summary>
    public static BottomBuilder Negative1 => new(BottomEnum.Negative1);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static BottomBuilder Token(string value) => new(value.StartsWith("bottom-") ? value : "bottom-" + value);
}
