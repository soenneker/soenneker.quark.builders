namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style slider sizing.
/// </summary>
public static class SliderSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static SliderSizeBuilder Default => new(SliderSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static SliderSizeBuilder Sm => new(SliderSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static SliderSizeBuilder Lg => new(SliderSizeEnum.Lg);

    /// <summary>
    /// Adds an arbitrary slider sizes utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static SliderSizeBuilder Token(string value) => new(value);
}
