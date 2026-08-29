namespace Soenneker.Quark;

/// <summary>
/// Represents the overflow wrap.
/// </summary>
[TailwindModifiers(typeof(OverflowWrapBuilder))]
public static partial class OverflowWrap
{
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public static OverflowWrapBuilder Normal => new(OverflowWrapEnum.Normal);
    /// <summary>
    /// Gets or sets anywhere.
    /// </summary>
    public static OverflowWrapBuilder Anywhere => new(OverflowWrapEnum.Anywhere);
    /// <summary>
    /// Gets or sets break word.
    /// </summary>
    public static OverflowWrapBuilder BreakWord => new(OverflowWrapEnum.BreakWord);
    /// <summary>
    /// Adds an arbitrary overflow wrap utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static OverflowWrapBuilder Token(string value) => new(value.StartsWith("wrap-") ? value : $"wrap-{value}");
}
