namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style select sizing.
/// </summary>
public static class SelectSizes
{
    public static SelectSizeBuilder Default => new("default");
    public static SelectSizeBuilder Sm => new("sm");

    public static SelectSizeBuilder Token(string value) => new(value);
}
