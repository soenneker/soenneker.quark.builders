namespace Soenneker.Quark;

/// <summary>
/// Represents the forced color adjust builder.
/// </summary>
[TailwindPrefix("forced-color-adjust-", Responsive = true)]
public sealed class ForcedColorAdjustBuilder : FinalClassUtilityBuilder<ForcedColorAdjustBuilder>
{
    internal ForcedColorAdjustBuilder() {}
    internal ForcedColorAdjustBuilder(ForcedColorAdjustEnum value) : base(value.Value) {}
    internal ForcedColorAdjustBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public ForcedColorAdjustBuilder Auto => ChainClass(ForcedColorAdjustEnum.Auto.Value);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public ForcedColorAdjustBuilder None => ChainClass(ForcedColorAdjustEnum.None.Value);
    /// <summary>
    /// Adds an arbitrary forced color adjust utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ForcedColorAdjustBuilder Token(string value) => ChainClass(value.StartsWith("forced-color-adjust-") ? value : $"forced-color-adjust-{value}");
}
