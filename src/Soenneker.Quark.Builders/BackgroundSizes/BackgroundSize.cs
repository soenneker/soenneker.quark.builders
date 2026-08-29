namespace Soenneker.Quark;

/// <summary>
/// Represents the background size.
/// </summary>
[TailwindModifiers(typeof(BackgroundSizeBuilder))]
public static partial class BackgroundSize
{
    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public static BackgroundSizeBuilder Auto => new(BackgroundSizeEnum.Auto);
    /// <summary>
    /// Gets or sets cover.
    /// </summary>
    public static BackgroundSizeBuilder Cover => new(BackgroundSizeEnum.Cover);
    /// <summary>
    /// Gets or sets contain.
    /// </summary>
    public static BackgroundSizeBuilder Contain => new(BackgroundSizeEnum.Contain);
    /// <summary>
    /// Adds an arbitrary background size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackgroundSizeBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
