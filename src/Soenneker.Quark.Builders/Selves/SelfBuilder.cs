namespace Soenneker.Quark;

/// <summary>
/// Represents the self builder.
/// </summary>
[TailwindPrefix("self-", Responsive = true)]
public sealed class SelfBuilder : ResponsiveUtilityBuilder<SelfBuilder>
{
    internal SelfBuilder()
    {
    }

    internal SelfBuilder(SelfEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal SelfBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public SelfBuilder Auto => ChainValue(SelfEnum.AutoValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public SelfBuilder Start => ChainValue(SelfEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public SelfBuilder End => ChainValue(SelfEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public SelfBuilder Center => ChainValue(SelfEnum.CenterValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public SelfBuilder Stretch => ChainValue(SelfEnum.StretchValue);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public SelfBuilder Baseline => ChainValue(SelfEnum.BaselineValue);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public SelfBuilder Token(string value) => ChainValue("self-" + value);

}
