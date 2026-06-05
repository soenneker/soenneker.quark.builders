namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style switch sizing.
/// </summary>
public static class SwitchSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static SwitchSizeBuilder Default => new(SwitchSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static SwitchSizeBuilder Sm => new(SwitchSizeEnum.Sm);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static SwitchSizeBuilder Token(string value) => new(value);
}
