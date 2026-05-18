namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style button sizing.
/// </summary>
[TailwindModifiers(typeof(ButtonSizeBuilder))]
public static partial class ButtonSize
{
    public static ButtonSizeBuilder Default => new(ButtonSizeEnum.Default);
    public static ButtonSizeBuilder Xs => new(ButtonSizeEnum.Xs);
    public static ButtonSizeBuilder Sm => new(ButtonSizeEnum.Sm);
    public static ButtonSizeBuilder Lg => new(ButtonSizeEnum.Lg);
    public static ButtonSizeBuilder Icon => new(ButtonSizeEnum.Icon);
    public static ButtonSizeBuilder IconXs => new(ButtonSizeEnum.IconXs);
    public static ButtonSizeBuilder IconSm => new(ButtonSizeEnum.IconSm);
    public static ButtonSizeBuilder IconLg => new(ButtonSizeEnum.IconLg);

    public static ButtonSizeBuilder Token(string value) => new(value);
}