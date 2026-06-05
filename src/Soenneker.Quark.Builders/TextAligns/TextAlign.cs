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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static TextAlignBuilder Token(string value) => new("text-" + value);
}
