namespace Soenneker.Quark;

/// <summary>
/// Entry points for pagination sizing.
/// </summary>
public static class PaginationSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static PaginationSizeBuilder Default => new(PaginationSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static PaginationSizeBuilder Sm => new(PaginationSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static PaginationSizeBuilder Lg => new(PaginationSizeEnum.Lg);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static PaginationSizeBuilder Token(string value) => new(value);
}
