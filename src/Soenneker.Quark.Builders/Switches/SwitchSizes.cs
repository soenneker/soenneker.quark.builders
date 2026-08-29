namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style switch sizing.
/// </summary>
public static class SwitchSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static SwitchSizeBuilder Default => new(SwitchSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static SwitchSizeBuilder Sm => new(SwitchSizeEnum.Sm);

    /// <summary>
    /// Adds an arbitrary switch sizes utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static SwitchSizeBuilder Token(string value) => new(value);
}
