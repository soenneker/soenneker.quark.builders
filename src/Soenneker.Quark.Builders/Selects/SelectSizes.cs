namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style select sizing.
/// </summary>
public static class SelectSizes
{
    public static SelectSizeBuilder Default => new(SelectSizeEnum.Default);
    public static SelectSizeBuilder Sm => new(SelectSizeEnum.Sm);

    public static SelectSizeBuilder Token(string value) => new(value);
}
