namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style checkbox sizing.
/// </summary>
public static class CheckSizes
{
    public static CheckSizeBuilder Default => new(CheckSizeEnum.Default);
    public static CheckSizeBuilder Xs => new(CheckSizeEnum.Xs);
    public static CheckSizeBuilder Sm => new(CheckSizeEnum.Sm);
    public static CheckSizeBuilder Md => new(CheckSizeEnum.Md);
    public static CheckSizeBuilder Lg => new(CheckSizeEnum.Lg);
    public static CheckSizeBuilder Xl => new(CheckSizeEnum.Xl);
    public static CheckSizeBuilder Xxl => new(CheckSizeEnum.Xxl);

    public static CheckSizeBuilder Token(string value) => new(value);
}
