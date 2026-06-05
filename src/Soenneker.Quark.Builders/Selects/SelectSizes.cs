namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style select sizing.
/// </summary>
public static class SelectSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static SelectSizeBuilder Default => new(SelectSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static SelectSizeBuilder Sm => new(SelectSizeEnum.Sm);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static SelectSizeBuilder Token(string value) => new(value);
}
