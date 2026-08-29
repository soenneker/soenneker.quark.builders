namespace Soenneker.Quark;

/// <summary>
/// Represents the justify builder.
/// </summary>
[TailwindPrefix("justify-", Responsive = true)]
public sealed class JustifyBuilder : ResponsiveUtilityBuilder<JustifyBuilder>
{
    internal JustifyBuilder()
    {
    }

    internal JustifyBuilder(JustifyEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal JustifyBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public JustifyBuilder Normal => ChainValue(JustifyEnum.NormalValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public JustifyBuilder Start => ChainValue(JustifyEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public JustifyBuilder End => ChainValue(JustifyEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public JustifyBuilder Center => ChainValue(JustifyEnum.CenterValue);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public JustifyBuilder Between => ChainValue(JustifyEnum.BetweenValue);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public JustifyBuilder Around => ChainValue(JustifyEnum.AroundValue);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public JustifyBuilder Evenly => ChainValue(JustifyEnum.EvenlyValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public JustifyBuilder Stretch => ChainValue(JustifyEnum.StretchValue);
    /// <summary>
    /// Adds an arbitrary justify utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public JustifyBuilder Token(string value) => ChainValue("justify-" + value);

}
