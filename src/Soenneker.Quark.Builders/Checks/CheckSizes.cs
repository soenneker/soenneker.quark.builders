namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style checkbox sizing.
/// </summary>
public static class CheckSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static CheckSizeBuilder Default => new(CheckSizeEnum.Default);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public static CheckSizeBuilder Xs => new(CheckSizeEnum.Xs);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static CheckSizeBuilder Sm => new(CheckSizeEnum.Sm);
    /// <summary>
    /// Gets or sets md.
    /// </summary>
    public static CheckSizeBuilder Md => new(CheckSizeEnum.Md);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static CheckSizeBuilder Lg => new(CheckSizeEnum.Lg);
    /// <summary>
    /// Gets or sets xl.
    /// </summary>
    public static CheckSizeBuilder Xl => new(CheckSizeEnum.Xl);
    /// <summary>
    /// Gets or sets xxl.
    /// </summary>
    public static CheckSizeBuilder Xxl => new(CheckSizeEnum.Xxl);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static CheckSizeBuilder Token(string value) => new(value);
}
