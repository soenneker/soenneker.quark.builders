namespace Soenneker.Quark;

/// <summary>
/// Represents the place items align.
/// </summary>
[TailwindModifiers(typeof(PlaceItemsAlignBuilder))]
public static partial class PlaceItemsAlign
{
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static PlaceItemsAlignBuilder Start => new(PlaceItemsAlignEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static PlaceItemsAlignBuilder End => new(PlaceItemsAlignEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static PlaceItemsAlignBuilder Center => new(PlaceItemsAlignEnum.Center);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public static PlaceItemsAlignBuilder Baseline => new(PlaceItemsAlignEnum.Baseline);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static PlaceItemsAlignBuilder Stretch => new(PlaceItemsAlignEnum.Stretch);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static PlaceItemsAlignBuilder Token(string value) => new(value.StartsWith("place-items-") ? value : $"place-items-{value}");
}
