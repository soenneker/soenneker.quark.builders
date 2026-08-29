namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration line builder.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class DecorationLineBuilder : ResponsiveUtilityBuilder<DecorationLineBuilder>
{
    internal DecorationLineBuilder()
    {
    }

    internal DecorationLineBuilder(DecorationLineEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal DecorationLineBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public DecorationLineBuilder None => ChainValue(DecorationLineEnum.NoneValue);
    /// <summary>
    /// Gets or sets underline.
    /// </summary>
    public DecorationLineBuilder Underline => ChainValue(DecorationLineEnum.UnderlineValue);
    /// <summary>
    /// Gets or sets line through.
    /// </summary>
    public DecorationLineBuilder LineThrough => ChainValue(DecorationLineEnum.LineThroughValue);
    /// <summary>
    /// Gets or sets overline.
    /// </summary>
    public DecorationLineBuilder Overline => ChainValue(DecorationLineEnum.OverlineValue);
    /// <summary>
    /// Adds an arbitrary decoration line utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DecorationLineBuilder Token(string value) => ChainValue(value);

}
