namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style radio sizing.
/// </summary>
public static class RadioSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static RadioSizeBuilder Default => new(RadioSizeEnum.Default);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public static RadioSizeBuilder Xs => new(RadioSizeEnum.Xs);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static RadioSizeBuilder Sm => new(RadioSizeEnum.Sm);
    /// <summary>
    /// Gets or sets md.
    /// </summary>
    public static RadioSizeBuilder Md => new(RadioSizeEnum.Md);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static RadioSizeBuilder Lg => new(RadioSizeEnum.Lg);
    /// <summary>
    /// Gets or sets xl.
    /// </summary>
    public static RadioSizeBuilder Xl => new(RadioSizeEnum.Xl);
    /// <summary>
    /// Gets or sets xxl.
    /// </summary>
    public static RadioSizeBuilder Xxl => new(RadioSizeEnum.Xxl);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static RadioSizeBuilder Token(string value) => new(value);
}
