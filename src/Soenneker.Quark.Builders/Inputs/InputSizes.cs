namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style text input sizing.
/// </summary>
public static class InputSizes
{
    public static InputSizeBuilder Default => new(InputSizeEnum.Default);
    public static InputSizeBuilder Sm => new(InputSizeEnum.Sm);
    public static InputSizeBuilder Lg => new(InputSizeEnum.Lg);

    public static InputSizeBuilder Token(string value) => new(value);
}
