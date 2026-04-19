namespace Soenneker.Quark;

/// <summary>
/// Entry points for pagination sizing.
/// </summary>
public static class PaginationSizes
{
    public static PaginationSizeBuilder Default => new("default");
    public static PaginationSizeBuilder Sm => new("sm");
    public static PaginationSizeBuilder Lg => new("lg");

    public static PaginationSizeBuilder Token(string value) => new(value);
}
