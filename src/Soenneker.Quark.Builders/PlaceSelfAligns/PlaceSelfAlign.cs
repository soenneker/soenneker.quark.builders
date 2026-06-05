namespace Soenneker.Quark;

/// <summary>
/// Represents the place self align.
/// </summary>
[TailwindModifiers(typeof(PlaceSelfAlignBuilder))]
public static partial class PlaceSelfAlign
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static PlaceSelfAlignBuilder Auto => new(PlaceSelfAlignEnum.Auto);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static PlaceSelfAlignBuilder Start => new(PlaceSelfAlignEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static PlaceSelfAlignBuilder End => new(PlaceSelfAlignEnum.End);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static PlaceSelfAlignBuilder Center => new(PlaceSelfAlignEnum.Center);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static PlaceSelfAlignBuilder Stretch => new(PlaceSelfAlignEnum.Stretch);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static PlaceSelfAlignBuilder Token(string value) => new(value.StartsWith("place-self-") ? value : $"place-self-{value}");
}
