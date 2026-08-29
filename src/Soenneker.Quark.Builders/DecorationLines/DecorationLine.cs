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
    /// Adds an arbitrary decoration line utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static DecorationLineBuilder Token(string value) => new(value);
}
