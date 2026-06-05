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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static JustifyItemsAlignBuilder Token(string value) => new("justify-items-" + value);
}
