namespace Soenneker.Quark;

/// <summary>
/// Represents the justify self align builder.
/// </summary>
[TailwindPrefix("justify-self-", Responsive = true)]
public sealed class JustifySelfAlignBuilder : FinalClassUtilityBuilder<JustifySelfAlignBuilder>
{
    internal JustifySelfAlignBuilder()
    {
    }

    internal JustifySelfAlignBuilder(JustifySelfAlignEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal JustifySelfAlignBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public JustifySelfAlignBuilder Auto => ChainClass(JustifySelfAlignEnum.AutoValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public JustifySelfAlignBuilder Start => ChainClass(JustifySelfAlignEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public JustifySelfAlignBuilder End => ChainClass(JustifySelfAlignEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public JustifySelfAlignBuilder Center => ChainClass(JustifySelfAlignEnum.CenterValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public JustifySelfAlignBuilder Stretch => ChainClass(JustifySelfAlignEnum.StretchValue);
    /// <summary>
    /// Adds an arbitrary justify self align utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public JustifySelfAlignBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "justify-self-"));

}
