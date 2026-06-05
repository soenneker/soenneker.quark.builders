namespace Soenneker.Quark;

/// <summary>
/// Represents the place items align builder.
/// </summary>
[TailwindPrefix("place-items-", Responsive = true)]
public sealed class PlaceItemsAlignBuilder : FinalClassUtilityBuilder<PlaceItemsAlignBuilder>
{
    internal PlaceItemsAlignBuilder() {}
    internal PlaceItemsAlignBuilder(PlaceItemsAlignEnum value) : base(value.Value) {}
    internal PlaceItemsAlignBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public PlaceItemsAlignBuilder Start => ChainClass(PlaceItemsAlignEnum.Start.Value);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public PlaceItemsAlignBuilder End => ChainClass(PlaceItemsAlignEnum.End.Value);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public PlaceItemsAlignBuilder Center => ChainClass(PlaceItemsAlignEnum.Center.Value);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public PlaceItemsAlignBuilder Baseline => ChainClass(PlaceItemsAlignEnum.Baseline.Value);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public PlaceItemsAlignBuilder Stretch => ChainClass(PlaceItemsAlignEnum.Stretch.Value);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public PlaceItemsAlignBuilder Token(string value) => ChainClass(value.StartsWith("place-items-") ? value : $"place-items-{value}");
}
