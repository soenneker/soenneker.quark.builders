namespace Soenneker.Quark;

/// <summary>
/// Represents the items builder.
/// </summary>
[TailwindPrefix("items-", Responsive = true)]
public sealed class ItemsBuilder : ResponsiveUtilityBuilder<ItemsBuilder>
{
    internal ItemsBuilder()
    {
    }

    internal ItemsBuilder(ItemsEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal ItemsBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public ItemsBuilder Start => ChainValue(ItemsEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public ItemsBuilder End => ChainValue(ItemsEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public ItemsBuilder Center => ChainValue(ItemsEnum.CenterValue);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public ItemsBuilder Baseline => ChainValue(ItemsEnum.BaselineValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public ItemsBuilder Stretch => ChainValue(ItemsEnum.StretchValue);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ItemsBuilder Token(string value) => ChainValue("items-" + value);

}
