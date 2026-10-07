namespace Soenneker.Quark;

/// <summary>
/// Represents the justify builder.
/// </summary>
[TailwindPrefix("justify-", Responsive = true)]
public sealed class JustifyBuilder : FinalClassUtilityBuilder<JustifyBuilder>
{
    internal JustifyBuilder()
    {
    }

    internal JustifyBuilder(JustifyEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal JustifyBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public JustifyBuilder Normal => ChainClass(JustifyEnum.NormalValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public JustifyBuilder Start => ChainClass(JustifyEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public JustifyBuilder End => ChainClass(JustifyEnum.EndValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public JustifyBuilder Center => ChainClass(JustifyEnum.CenterValue);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public JustifyBuilder Between => ChainClass(JustifyEnum.BetweenValue);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public JustifyBuilder Around => ChainClass(JustifyEnum.AroundValue);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public JustifyBuilder Evenly => ChainClass(JustifyEnum.EvenlyValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public JustifyBuilder Stretch => ChainClass(JustifyEnum.StretchValue);
    /// <summary>
    /// Adds an arbitrary justify utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public JustifyBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "justify-"));

}
