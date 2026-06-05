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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static OverflowWrapBuilder Token(string value) => new(value.StartsWith("wrap-") ? value : $"wrap-{value}");
}
