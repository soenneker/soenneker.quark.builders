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
    /// Adds an arbitrary pagination sizes utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static PaginationSizeBuilder Token(string value) => new(value);
}
