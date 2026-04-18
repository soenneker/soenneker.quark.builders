namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating text transform builders with predefined values.
/// </summary>
public static class TextTransform
{
    /// <summary>
    /// Gets a text transform builder with lowercase value (text is lowercase).
    /// </summary>
    public static TextTransformBuilder Lowercase => new(TextTransformEnum.Lowercase);
    /// <summary>
    /// Gets a text transform builder with uppercase value (text is uppercase).
    /// </summary>
    public static TextTransformBuilder Uppercase => new(TextTransformEnum.Uppercase);
    /// <summary>
    /// Gets a text transform builder with capitalize value (first letter of each word is capitalized).
    /// </summary>
    public static TextTransformBuilder Capitalize => new(TextTransformEnum.Capitalize);
}
