namespace Soenneker.Quark;

/// <summary>
/// Represents the decoration line builder.
/// </summary>
[TailwindPrefix("", Responsive = true)]
public sealed class DecorationLineBuilder : FinalClassUtilityBuilder<DecorationLineBuilder>
{
    internal DecorationLineBuilder()
    {
    }

    internal DecorationLineBuilder(DecorationLineEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal DecorationLineBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public DecorationLineBuilder None => ChainClass(DecorationLineEnum.NoneValue);
    /// <summary>
    /// Gets or sets underline.
    /// </summary>
    public DecorationLineBuilder Underline => ChainClass(DecorationLineEnum.UnderlineValue);
    /// <summary>
    /// Gets or sets line through.
    /// </summary>
    public DecorationLineBuilder LineThrough => ChainClass(DecorationLineEnum.LineThroughValue);
    /// <summary>
    /// Gets or sets overline.
    /// </summary>
    public DecorationLineBuilder Overline => ChainClass(DecorationLineEnum.OverlineValue);
    /// <summary>
    /// Adds an arbitrary decoration line utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public DecorationLineBuilder Token(string value) => ChainClass(value);

}
