namespace Soenneker.Quark;

/// <summary>
/// Represents the justify items align builder.
/// </summary>
[TailwindPrefix("justify-items-", Responsive = true)]
public sealed class JustifyItemsAlignBuilder : ResponsiveUtilityBuilder<JustifyItemsAlignBuilder>
{
    internal JustifyItemsAlignBuilder()
    {
    }

    internal JustifyItemsAlignBuilder(JustifyItemsAlignEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal JustifyItemsAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public JustifyItemsAlignBuilder Normal => ChainValue(JustifyItemsAlignEnum.NormalValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public JustifyItemsAlignBuilder Start => ChainValue(JustifyItemsAlignEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public JustifyItemsAlignBuilder End => ChainValue(JustifyItemsAlignEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public JustifyItemsAlignBuilder Center => ChainValue(JustifyItemsAlignEnum.CenterValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public JustifyItemsAlignBuilder Stretch => ChainValue(JustifyItemsAlignEnum.StretchValue);
    /// <summary>
    /// Adds an arbitrary justify items align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public JustifyItemsAlignBuilder Token(string value) => ChainValue("justify-items-" + value);

}
