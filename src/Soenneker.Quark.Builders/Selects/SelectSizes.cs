namespace Soenneker.Quark;

/// <summary>
/// Entry points for shadcn-style select sizing.
/// </summary>
public static class SelectSizes
{
    /// <summary>
    /// Gets or sets default.
    /// </summary>
    public static SelectSizeBuilder Default => new(SelectSizeEnum.Default);
    /// <summary>
    /// Gets or sets sm.
    /// </summary>
    public static SelectSizeBuilder Sm => new(SelectSizeEnum.Sm);

    /// <summary>
    /// Adds an arbitrary select sizes utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static SelectSizeBuilder Token(string value) => new(value);
}
