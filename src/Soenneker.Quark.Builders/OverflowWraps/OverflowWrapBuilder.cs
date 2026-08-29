namespace Soenneker.Quark;

/// <summary>
/// Represents the overflow wrap builder.
/// </summary>
[TailwindPrefix("wrap-", Responsive = true)]
public sealed class OverflowWrapBuilder : FinalClassUtilityBuilder<OverflowWrapBuilder>
{
    internal OverflowWrapBuilder() {}
    internal OverflowWrapBuilder(OverflowWrapEnum value) : base(value.Value) {}
    internal OverflowWrapBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public OverflowWrapBuilder Normal => ChainClass(OverflowWrapEnum.Normal.Value);
    /// <summary>
    /// Gets or sets anywhere.
    /// </summary>
    public OverflowWrapBuilder Anywhere => ChainClass(OverflowWrapEnum.Anywhere.Value);
    /// <summary>
    /// Gets or sets break word.
    /// </summary>
    public OverflowWrapBuilder BreakWord => ChainClass(OverflowWrapEnum.BreakWord.Value);
    /// <summary>
    /// Adds an arbitrary overflow wrap utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OverflowWrapBuilder Token(string value) => ChainClass(value.StartsWith("wrap-") ? value : $"wrap-{value}");
}
