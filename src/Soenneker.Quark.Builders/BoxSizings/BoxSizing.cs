namespace Soenneker.Quark;

/// <summary>
/// Represents the box sizing.
/// </summary>
[TailwindModifiers(typeof(BoxSizingBuilder))]
public static partial class BoxSizing
{
    /// <summary>
    /// Gets or sets border.
    /// </summary>
    public static BoxSizingBuilder Border => new(BoxSizingEnum.Border);
    /// <summary>
    /// Gets or sets content.
    /// </summary>
    public static BoxSizingBuilder Content => new(BoxSizingEnum.Content);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static BoxSizingBuilder Token(string value) => new(value.StartsWith("box-") ? value : $"box-{value}");
}
