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
    /// Adds an arbitrary place items align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static PlaceItemsAlignBuilder Token(string value) => new(value.StartsWith("place-items-") ? value : $"place-items-{value}");
}
