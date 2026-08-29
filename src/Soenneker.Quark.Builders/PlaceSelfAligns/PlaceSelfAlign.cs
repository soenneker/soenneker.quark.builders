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
    /// Adds an arbitrary place self align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static PlaceSelfAlignBuilder Token(string value) => new(value.StartsWith("place-self-") ? value : $"place-self-{value}");
}
