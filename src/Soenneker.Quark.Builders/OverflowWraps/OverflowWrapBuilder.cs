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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public OverflowWrapBuilder Token(string value) => ChainClass(value.StartsWith("wrap-") ? value : $"wrap-{value}");
}
