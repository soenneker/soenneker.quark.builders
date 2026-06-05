namespace Soenneker.Quark;

/// <summary>
/// Static utility for left (left offset). Tailwind: left-*.
/// </summary>
[TailwindModifiers(typeof(LeftBuilder))]
public static partial class Left
{
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static LeftBuilder Is0 => new(LeftEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static LeftBuilder Is1 => new(LeftEnum.Is1);
    /// <summary>
    /// Gets or sets is1 5.
    /// </summary>
    public static LeftBuilder Is1_5 => new(LeftEnum.Is1_5);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static LeftBuilder Is2 => new(LeftEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static LeftBuilder Is3 => new(LeftEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static LeftBuilder Is4 => new(LeftEnum.Is4);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static LeftBuilder Is5 => new(LeftEnum.Is5);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static LeftBuilder Is8 => new(LeftEnum.Is8);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static LeftBuilder Is12 => new(LeftEnum.Is12);
    /// <summary>
    /// Gets or sets is16.
    /// </summary>
    public static LeftBuilder Is16 => new(LeftEnum.Is16);
    /// <summary>
    /// Gets or sets is24.
    /// </summary>
    public static LeftBuilder Is24 => new(LeftEnum.Is24);
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static LeftBuilder Auto => new(LeftEnum.Auto);
    /// <summary>
    /// Gets or sets px.
    /// </summary>
    public static LeftBuilder Px => new(LeftEnum.Px);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static LeftBuilder Token(string value) => new(value.StartsWith("left-") ? value : "left-" + value);
}
