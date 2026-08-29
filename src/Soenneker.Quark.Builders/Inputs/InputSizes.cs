namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style text input sizing.
/// </summary>
public static class InputSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static InputSizeBuilder Default => new(InputSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static InputSizeBuilder Sm => new(InputSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static InputSizeBuilder Lg => new(InputSizeEnum.Lg);

    /// <summary>
    /// Adds an arbitrary input sizes utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static InputSizeBuilder Token(string value) => new(value);
}
