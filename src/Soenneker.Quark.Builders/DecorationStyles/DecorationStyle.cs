namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration style.
/// </summary>
[TailwindModifiers(typeof(DecorationStyleBuilder))]
public static partial class DecorationStyle
{
    /// <summary>
    /// Gets or sets solid.
    /// </summary>
    public static DecorationStyleBuilder Solid => new(DecorationStyleEnum.Solid);
    /// <summary>
    /// Gets or sets double.
    /// </summary>
    public static DecorationStyleBuilder Double => new(DecorationStyleEnum.Double);
    /// <summary>
    /// Gets or sets dotted.
    /// </summary>
    public static DecorationStyleBuilder Dotted => new(DecorationStyleEnum.Dotted);
    /// <summary>
    /// Gets or sets dashed.
    /// </summary>
    public static DecorationStyleBuilder Dashed => new(DecorationStyleEnum.Dashed);
    /// <summary>
    /// Gets or sets wavy.
    /// </summary>
    public static DecorationStyleBuilder Wavy => new(DecorationStyleEnum.Wavy);
    /// <summary>
    /// Adds an arbitrary decoration style utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static DecorationStyleBuilder Token(string value) => new("decoration-" + value);
}
