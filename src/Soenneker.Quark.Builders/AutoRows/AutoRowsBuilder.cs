namespace Soenneker.Quark;

/// <summary>
/// Represents the auto rows builder.
/// </summary>
[TailwindPrefix("auto-rows-", Responsive = true)]
public sealed class AutoRowsBuilder : FinalClassUtilityBuilder<AutoRowsBuilder>
{
    internal AutoRowsBuilder()
    {
    }

    internal AutoRowsBuilder(AutoRowsEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint) {}
    internal AutoRowsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public AutoRowsBuilder Auto => ChainClass(AutoRowsEnum.AutoValue);
    /// <summary>
    /// Gets or sets min.
    /// </summary>
    public AutoRowsBuilder Min => ChainClass(AutoRowsEnum.MinValue);
    /// <summary>
    /// Gets or sets max.
    /// </summary>
    public AutoRowsBuilder Max => ChainClass(AutoRowsEnum.MaxValue);
    /// <summary>
    /// Gets or sets fr.
    /// </summary>
    public AutoRowsBuilder Fr => ChainClass(AutoRowsEnum.FrValue);
    /// <summary>
    /// Adds an arbitrary auto rows utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public AutoRowsBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "auto-rows-"));

}
