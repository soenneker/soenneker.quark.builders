namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration thickness.
/// </summary>
[TailwindModifiers(typeof(DecorationThicknessBuilder))]
public static partial class DecorationThickness
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static DecorationThicknessBuilder Auto => new(DecorationThicknessEnum.Auto);
    /// <summary>
    /// Gets or sets from font.
    /// </summary>
    public static DecorationThicknessBuilder FromFont => new(DecorationThicknessEnum.FromFont);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static DecorationThicknessBuilder Is0 => new(DecorationThicknessEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static DecorationThicknessBuilder Is1 => new(DecorationThicknessEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static DecorationThicknessBuilder Is2 => new(DecorationThicknessEnum.Is2);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static DecorationThicknessBuilder Is4 => new(DecorationThicknessEnum.Is4);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static DecorationThicknessBuilder Is8 => new(DecorationThicknessEnum.Is8);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static DecorationThicknessBuilder Token(string value) => new("decoration-" + value);
}
