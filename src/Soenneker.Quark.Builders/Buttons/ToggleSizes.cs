namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style toggle sizing.
/// </summary>
public static class ToggleSizes
{
    public static ToggleSizeBuilder Default => new("h-9 min-w-9 px-2");
    public static ToggleSizeBuilder Sm => new("h-8 min-w-8 px-1.5");
    public static ToggleSizeBuilder Lg => new("h-10 min-w-10 px-2.5");

    public static ToggleSizeBuilder Token(string value) => new(value);
}