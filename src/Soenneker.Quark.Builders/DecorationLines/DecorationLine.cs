namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration line.
/// </summary>
[TailwindModifiers(typeof(DecorationLineBuilder))]
public static partial class DecorationLine
{
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static DecorationLineBuilder None => new(DecorationLineEnum.None);
    /// <summary>
    /// Gets or sets underline.
    /// </summary>
    public static DecorationLineBuilder Underline => new(DecorationLineEnum.Underline);
    /// <summary>
    /// Gets or sets line through.
    /// </summary>
    public static DecorationLineBuilder LineThrough => new(DecorationLineEnum.LineThrough);
    /// <summary>
    /// Gets or sets overline.
    /// </summary>
    public static DecorationLineBuilder Overline => new(DecorationLineEnum.Overline);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static DecorationLineBuilder Token(string value) => new(value);
}
