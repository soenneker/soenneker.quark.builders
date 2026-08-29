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
    /// Adds an arbitrary box sizing utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BoxSizingBuilder Token(string value) => new(value.StartsWith("box-") ? value : $"box-{value}");
}
