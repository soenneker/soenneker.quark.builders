namespace Soenneker.Quark;

/// <summary>
/// Static utility for top (top offset). Tailwind: top-*.
/// </summary>
[TailwindModifiers(typeof(TopBuilder))]
public static partial class Top
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static TopBuilder Is0 => new(TopEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static TopBuilder Is1 => new(TopEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static TopBuilder Is1_5 => new(TopEnum.Is1_5);
    /// <summary>
    /// Gets or sets is1of2.
    /// </summary>
    public static TopBuilder Is1of2 => new(TopEnum.Is1of2);
    /// <summary>
    /// Gets or sets is1of3.
    /// </summary>
    public static TopBuilder Is1of3 => new(TopEnum.Is1of3);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static TopBuilder Is2 => new(TopEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static TopBuilder Is3 => new(TopEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static TopBuilder Is4 => new(TopEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static TopBuilder Is5 => new(TopEnum.Is5);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static TopBuilder Is8 => new(TopEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static TopBuilder Is12 => new(TopEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public static TopBuilder Is16 => new(TopEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public static TopBuilder Is24 => new(TopEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static TopBuilder Auto => new(TopEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public static TopBuilder Px => new(TopEnum.Px);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static TopBuilder Token(string value) => new(value.StartsWith("top-") ? value : "top-" + value);
}
