namespace Soenneker.Quark;

/// <summary>
/// Represents the fill.
/// </summary>
[TailwindModifiers(typeof(FillBuilder))]
public static partial class Fill
{
    /// <summary>
    /// Tailwind token segment (spacing scale step, arbitrary value like `[17rem]`, or theme key). Builds the matching utility class for this builder.
    /// </summary>
    /// <param name="value">Suffix/token after the utility prefix (see Tailwind docs for this family).</param>
    public static FillBuilder Token(string value) => new($"fill-{value}");
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static FillBuilder None => new(FillEnum.None);
    /// <summary>
    /// `currentColor` — uses the element’s computed `color` (common for icons and rings).
    /// </summary>
    public static FillBuilder Current => new(FillEnum.Current);
}
