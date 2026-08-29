namespace Soenneker.Quark;

/// <summary>
/// Represents the border style.
/// </summary>
[TailwindModifiers(typeof(BorderStyleBuilder))]
public static partial class BorderStyle
{
    /// <summary>
    /// Gets or sets solid.
    /// </summary>
    public static BorderStyleBuilder Solid => new(BorderStyleEnum.Solid);
    /// <summary>
    /// Gets or sets dashed.
    /// </summary>
    public static BorderStyleBuilder Dashed => new(BorderStyleEnum.Dashed);
    /// <summary>
    /// Gets or sets dotted.
    /// </summary>
    public static BorderStyleBuilder Dotted => new(BorderStyleEnum.Dotted);
    /// <summary>
    /// Gets or sets double.
    /// </summary>
    public static BorderStyleBuilder Double => new(BorderStyleEnum.Double);
    /// <summary>
    /// Gets or sets hidden.
    /// </summary>
    public static BorderStyleBuilder Hidden => new(BorderStyleEnum.Hidden);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static BorderStyleBuilder None => new(BorderStyleEnum.None);
    /// <summary>
    /// Adds an arbitrary border style utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BorderStyleBuilder Token(string value) => new(value.StartsWith("border-") ? value : $"border-{value}");
}
