namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style text input sizing.
/// </summary>
public static class InputSizes
{
    public static InputSizeBuilder Default => new("default");
    public static InputSizeBuilder Sm => new("sm");
    public static InputSizeBuilder Lg => new("lg");

    public static InputSizeBuilder Token(string value) => new(value);
}
