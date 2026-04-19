namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style switch sizing.
/// </summary>
public static class SwitchSizes
{
    public static SwitchSizeBuilder Default => new(SwitchSizeEnum.Default);
    public static SwitchSizeBuilder Sm => new(SwitchSizeEnum.Sm);

    public static SwitchSizeBuilder Token(string value) => new(value);
}
