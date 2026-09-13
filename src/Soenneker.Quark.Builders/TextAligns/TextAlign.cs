namespace Soenneker.Quark;

/// <summary>
/// Represents the text align.
/// </summary>
[TailwindModifiers(typeof(TextAlignBuilder))]
public static partial class TextAlign
{
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static TextAlignBuilder Start => new(TextAlignmentEnum.Start);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public static TextAlignBuilder Left => new("text-left");
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static TextAlignBuilder Center => new(TextAlignmentEnum.Center);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public static TextAlignBuilder Right => new("text-right");
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static TextAlignBuilder End => new(TextAlignmentEnum.End);
    /// <summary>
    /// Adds an arbitrary text align utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static TextAlignBuilder Token(string value) => new(UtilityToken.WithPrefix(value, "text-"));
}
