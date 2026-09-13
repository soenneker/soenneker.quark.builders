namespace Soenneker.Quark;

/// <summary>
/// Represents the justify self align builder.
/// </summary>
[TailwindPrefix("justify-self-", Responsive = true)]
public sealed class JustifySelfAlignBuilder : ResponsiveUtilityBuilder<JustifySelfAlignBuilder>
{
    internal JustifySelfAlignBuilder()
    {
    }

    internal JustifySelfAlignBuilder(JustifySelfAlignEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal JustifySelfAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public JustifySelfAlignBuilder Auto => ChainValue(JustifySelfAlignEnum.AutoValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public JustifySelfAlignBuilder Start => ChainValue(JustifySelfAlignEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public JustifySelfAlignBuilder End => ChainValue(JustifySelfAlignEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public JustifySelfAlignBuilder Center => ChainValue(JustifySelfAlignEnum.CenterValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public JustifySelfAlignBuilder Stretch => ChainValue(JustifySelfAlignEnum.StretchValue);
    /// <summary>
    /// Adds an arbitrary justify self align utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix or complete utility with this builder's prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public JustifySelfAlignBuilder Token(string value) => ChainValue(UtilityToken.WithPrefix(value, "justify-self-"));

}
