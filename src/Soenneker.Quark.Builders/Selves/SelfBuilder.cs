namespace Soenneker.Quark;

/// <summary>
/// Represents the self builder.
/// </summary>
[TailwindPrefix("self-", Responsive = true)]
public sealed class SelfBuilder : FinalClassUtilityBuilder<SelfBuilder>
{
    internal SelfBuilder()
    {
    }

    internal SelfBuilder(SelfEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal SelfBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public SelfBuilder Auto => ChainClass(SelfEnum.AutoValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public SelfBuilder Start => ChainClass(SelfEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public SelfBuilder End => ChainClass(SelfEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public SelfBuilder Center => ChainClass(SelfEnum.CenterValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public SelfBuilder Stretch => ChainClass(SelfEnum.StretchValue);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public SelfBuilder Baseline => ChainClass(SelfEnum.BaselineValue);
    /// <summary>
    /// Adds an arbitrary self utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public SelfBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "self-"));

}
