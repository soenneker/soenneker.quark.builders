namespace Soenneker.Quark;

/// <summary>
/// Represents the forced color adjust.
/// </summary>
[TailwindModifiers(typeof(ForcedColorAdjustBuilder))]
public static partial class ForcedColorAdjust
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static ForcedColorAdjustBuilder Auto => new(ForcedColorAdjustEnum.Auto);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static ForcedColorAdjustBuilder None => new(ForcedColorAdjustEnum.None);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ForcedColorAdjustBuilder Token(string value) => new(value.StartsWith("forced-color-adjust-") ? value : $"forced-color-adjust-{value}");
}
