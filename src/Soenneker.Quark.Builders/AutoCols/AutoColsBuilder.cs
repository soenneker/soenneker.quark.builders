namespace Soenneker.Quark;

/// <summary>
/// Represents the auto cols builder.
/// </summary>
[TailwindPrefix("auto-cols-", Responsive = true)]
public sealed class AutoColsBuilder : FinalClassUtilityBuilder<AutoColsBuilder>
{
    internal AutoColsBuilder()
    {
    }

    internal AutoColsBuilder(AutoColsEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint) {}
    internal AutoColsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public AutoColsBuilder Auto => ChainClass(AutoColsEnum.AutoValue);
    /// <summary>
    /// Gets or sets min.
    /// </summary>
    public AutoColsBuilder Min => ChainClass(AutoColsEnum.MinValue);
    /// <summary>
    /// Gets or sets max.
    /// </summary>
    public AutoColsBuilder Max => ChainClass(AutoColsEnum.MaxValue);
    /// <summary>
    /// Gets or sets fr.
    /// </summary>
    public AutoColsBuilder Fr => ChainClass(AutoColsEnum.FrValue);
    /// <summary>
    /// Adds an arbitrary auto cols utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public AutoColsBuilder Token(string value) => ChainClass("auto-cols-" + value);

}
