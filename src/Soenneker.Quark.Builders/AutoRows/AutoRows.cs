namespace Soenneker.Quark;

/// <summary>
/// Represents the auto rows.
/// </summary>
[TailwindModifiers(typeof(AutoRowsBuilder))]
public static partial class AutoRows
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static AutoRowsBuilder Auto => new(AutoRowsEnum.Auto);
    /// <summary>
    /// Gets or sets min.
    /// </summary>
    public static AutoRowsBuilder Min => new(AutoRowsEnum.Min);
    /// <summary>
    /// Gets or sets max.
    /// </summary>
    public static AutoRowsBuilder Max => new(AutoRowsEnum.Max);
    /// <summary>
    /// Gets or sets fr.
    /// </summary>
    public static AutoRowsBuilder Fr => new(AutoRowsEnum.Fr);
    /// <summary>
    /// Adds an arbitrary auto rows utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static AutoRowsBuilder Token(string value) => new($"auto-rows-{value}");
}
