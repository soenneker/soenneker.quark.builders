namespace Soenneker.Quark;

/// <summary>
/// Represents the stroke.
/// </summary>
[TailwindModifiers(typeof(StrokeBuilder))]
public static partial class Stroke
{
    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static StrokeBuilder Token(string value) => new($"stroke-{value}");
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static StrokeBuilder None => new(StrokeEnum.None);
    /// <summary>
    /// Gets or sets current.
    /// </summary>
    public static StrokeBuilder Current => new(StrokeEnum.Current);
}
