namespace Soenneker.Quark;

/// <summary>
/// Represents the place self align builder.
/// </summary>
[TailwindPrefix("place-self-", Responsive = true)]
public sealed class PlaceSelfAlignBuilder : FinalClassUtilityBuilder<PlaceSelfAlignBuilder>
{
    internal PlaceSelfAlignBuilder() {}
    internal PlaceSelfAlignBuilder(PlaceSelfAlignEnum value) : base(value.Value) {}
    internal PlaceSelfAlignBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public PlaceSelfAlignBuilder Auto => ChainClass(PlaceSelfAlignEnum.Auto.Value);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public PlaceSelfAlignBuilder Start => ChainClass(PlaceSelfAlignEnum.Start.Value);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public PlaceSelfAlignBuilder End => ChainClass(PlaceSelfAlignEnum.End.Value);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public PlaceSelfAlignBuilder Center => ChainClass(PlaceSelfAlignEnum.Center.Value);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public PlaceSelfAlignBuilder Stretch => ChainClass(PlaceSelfAlignEnum.Stretch.Value);
    /// <summary>
    /// Adds an arbitrary place self align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public PlaceSelfAlignBuilder Token(string value) => ChainClass(value.StartsWith("place-self-") ? value : $"place-self-{value}");
}
