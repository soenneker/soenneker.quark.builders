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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ForcedColorAdjustBuilder Token(string value) => ChainClass(value.StartsWith("forced-color-adjust-") ? value : $"forced-color-adjust-{value}");
}
