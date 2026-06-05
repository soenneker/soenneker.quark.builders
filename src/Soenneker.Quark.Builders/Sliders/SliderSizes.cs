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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static SliderSizeBuilder Token(string value) => new(value);
}
