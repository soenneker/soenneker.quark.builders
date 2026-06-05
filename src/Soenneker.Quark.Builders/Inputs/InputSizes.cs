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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static InputSizeBuilder Token(string value) => new(value);
}
