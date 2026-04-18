namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style toggle sizing.
/// </summary>
public static class ToggleSizes
{
    public static ToggleSizeBuilder Default => new("default");
    public static ToggleSizeBuilder Small => new("small");
    public static ToggleSizeBuilder Large => new("large");

    public static ToggleSizeBuilder Token(string value) => new(value);
}
