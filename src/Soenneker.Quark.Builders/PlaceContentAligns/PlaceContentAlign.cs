namespace Soenneker.Quark;

/// <summary>
/// Represents the place content align.
/// </summary>
[TailwindModifiers(typeof(PlaceContentAlignBuilder))]
public static partial class PlaceContentAlign
{
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static PlaceContentAlignBuilder Center => new(PlaceContentAlignEnum.Center);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static PlaceContentAlignBuilder Start => new(PlaceContentAlignEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static PlaceContentAlignBuilder End => new(PlaceContentAlignEnum.End);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public static PlaceContentAlignBuilder Between => new(PlaceContentAlignEnum.Between);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public static PlaceContentAlignBuilder Around => new(PlaceContentAlignEnum.Around);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public static PlaceContentAlignBuilder Evenly => new(PlaceContentAlignEnum.Evenly);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static PlaceContentAlignBuilder Stretch => new(PlaceContentAlignEnum.Stretch);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public static PlaceContentAlignBuilder Baseline => new(PlaceContentAlignEnum.Baseline);
    /// <summary>
    /// Adds an arbitrary place content align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static PlaceContentAlignBuilder Token(string value) => new(value.StartsWith("place-content-") ? value : $"place-content-{value}");
}
