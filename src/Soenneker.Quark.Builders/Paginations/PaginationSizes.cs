namespace Soenneker.Quark;

/// <summary>
/// Entry points for pagination sizing.
/// </summary>
public static class PaginationSizes
{
    public static PaginationSizeBuilder Default => new(PaginationSizeEnum.Default);
    public static PaginationSizeBuilder Sm => new(PaginationSizeEnum.Sm);
    public static PaginationSizeBuilder Lg => new(PaginationSizeEnum.Lg);

    public static PaginationSizeBuilder Token(string value) => new(value);
}
