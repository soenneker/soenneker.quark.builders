namespace Soenneker.Quark;

/// <summary>
/// Represents the justify items align.
/// </summary>
[TailwindModifiers(typeof(JustifyItemsAlignBuilder))]
public static partial class JustifyItemsAlign
{
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public static JustifyItemsAlignBuilder Normal => new(JustifyItemsAlignEnum.Normal);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static JustifyItemsAlignBuilder Start => new(JustifyItemsAlignEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static JustifyItemsAlignBuilder End => new(JustifyItemsAlignEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static JustifyItemsAlignBuilder Center => new(JustifyItemsAlignEnum.Center);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static JustifyItemsAlignBuilder Stretch => new(JustifyItemsAlignEnum.Stretch);
    /// <summary>
    /// Adds an arbitrary justify items align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static JustifyItemsAlignBuilder Token(string value) => new("justify-items-" + value);
}
