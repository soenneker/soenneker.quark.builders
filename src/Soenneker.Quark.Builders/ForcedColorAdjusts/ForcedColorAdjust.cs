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
    /// Adds an arbitrary forced color adjust utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ForcedColorAdjustBuilder Token(string value) => new(value.StartsWith("forced-color-adjust-") ? value : $"forced-color-adjust-{value}");
}
