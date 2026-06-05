namespace Soenneker.Quark;

/// <summary>
/// Entry points for responsive shadcn-style button sizing.
/// </summary>
[TailwindModifiers(typeof(ButtonSizeBuilder))]
public static partial class ButtonSize
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static ButtonSizeBuilder Default => new(ButtonSizeEnum.Default);
    /// <summary>
    /// Gets or sets xs.
    /// </summary>
    public static ButtonSizeBuilder Xs => new(ButtonSizeEnum.Xs);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static ButtonSizeBuilder Sm => new(ButtonSizeEnum.Sm);
    /// <summary>
    /// Gets or sets lg.
    /// </summary>
    public static ButtonSizeBuilder Lg => new(ButtonSizeEnum.Lg);
    /// <summary>
    /// Gets or sets icon.
    /// </summary>
    public static ButtonSizeBuilder Icon => new(ButtonSizeEnum.Icon);
    /// <summary>
    /// Gets or sets icon xs.
    /// </summary>
    public static ButtonSizeBuilder IconXs => new(ButtonSizeEnum.IconXs);
    /// <summary>
    /// Gets or sets icon sm.
    /// </summary>
    public static ButtonSizeBuilder IconSm => new(ButtonSizeEnum.IconSm);
    /// <summary>
    /// Gets or sets icon lg.
    /// </summary>
    public static ButtonSizeBuilder IconLg => new(ButtonSizeEnum.IconLg);

    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ButtonSizeBuilder Token(string value) => new(value);
}