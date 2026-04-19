namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style switch sizing.
/// </summary>
public static class SwitchSizes
{
    public static SwitchSizeBuilder Default => new("default");
    public static SwitchSizeBuilder Sm => new("sm");

    public static SwitchSizeBuilder Token(string value) => new(value);
}
