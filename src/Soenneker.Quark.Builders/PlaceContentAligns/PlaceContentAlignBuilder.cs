namespace Soenneker.Quark;

/// <summary>
/// Represents the place content align builder.
/// </summary>
[TailwindPrefix("place-content-", Responsive = true)]
public sealed class PlaceContentAlignBuilder : FinalClassUtilityBuilder<PlaceContentAlignBuilder>
{
    internal PlaceContentAlignBuilder() {}
    internal PlaceContentAlignBuilder(PlaceContentAlignEnum value) : base(value.Value) {}
    internal PlaceContentAlignBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public PlaceContentAlignBuilder Center => ChainClass(PlaceContentAlignEnum.Center.Value);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public PlaceContentAlignBuilder Start => ChainClass(PlaceContentAlignEnum.Start.Value);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public PlaceContentAlignBuilder End => ChainClass(PlaceContentAlignEnum.End.Value);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public PlaceContentAlignBuilder Between => ChainClass(PlaceContentAlignEnum.Between.Value);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public PlaceContentAlignBuilder Around => ChainClass(PlaceContentAlignEnum.Around.Value);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public PlaceContentAlignBuilder Evenly => ChainClass(PlaceContentAlignEnum.Evenly.Value);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public PlaceContentAlignBuilder Stretch => ChainClass(PlaceContentAlignEnum.Stretch.Value);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public PlaceContentAlignBuilder Baseline => ChainClass(PlaceContentAlignEnum.Baseline.Value);
    /// <summary>
    /// Adds an arbitrary place content align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public PlaceContentAlignBuilder Token(string value) => ChainClass(value.StartsWith("place-content-") ? value : $"place-content-{value}");
}
