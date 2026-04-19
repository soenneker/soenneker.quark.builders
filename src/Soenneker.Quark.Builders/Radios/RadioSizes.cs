namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style radio sizing.
/// </summary>
public static class RadioSizes
{
    public static RadioSizeBuilder Default => new(RadioSizeEnum.Default);
    public static RadioSizeBuilder Xs => new(RadioSizeEnum.Xs);
    public static RadioSizeBuilder Sm => new(RadioSizeEnum.Sm);
    public static RadioSizeBuilder Md => new(RadioSizeEnum.Md);
    public static RadioSizeBuilder Lg => new(RadioSizeEnum.Lg);
    public static RadioSizeBuilder Xl => new(RadioSizeEnum.Xl);
    public static RadioSizeBuilder Xxl => new(RadioSizeEnum.Xxl);

    public static RadioSizeBuilder Token(string value) => new(value);
}
