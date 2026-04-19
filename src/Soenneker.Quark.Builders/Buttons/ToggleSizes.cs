namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style toggle sizing.
/// </summary>
public static class ToggleSizes
{
    public static ToggleSizeBuilder Default => new("default");
    public static ToggleSizeBuilder Sm => new("sm");
    public static ToggleSizeBuilder Lg => new("lg");

    public static ToggleSizeBuilder Token(string value) => new(value);
}
