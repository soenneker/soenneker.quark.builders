namespace Soenneker.Quark;

/// <summary>
/// Represents the content align builder.
/// </summary>
[TailwindPrefix("content-", Responsive = true)]
public sealed class ContentAlignBuilder : ResponsiveUtilityBuilder<ContentAlignBuilder>
{
    internal ContentAlignBuilder()
    {
    }

    internal ContentAlignBuilder(ContentEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal ContentAlignBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public ContentAlignBuilder Normal => ChainValue(ContentEnum.NormalValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public ContentAlignBuilder Center => ChainValue(ContentEnum.CenterValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public ContentAlignBuilder Start => ChainValue(ContentEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public ContentAlignBuilder End => ChainValue(ContentEnum.EndValue);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public ContentAlignBuilder Between => ChainValue(ContentEnum.BetweenValue);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public ContentAlignBuilder Around => ChainValue(ContentEnum.AroundValue);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public ContentAlignBuilder Evenly => ChainValue(ContentEnum.EvenlyValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public ContentAlignBuilder Stretch => ChainValue(ContentEnum.StretchValue);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public ContentAlignBuilder Baseline => ChainValue(ContentEnum.BaselineValue);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public ContentAlignBuilder Token(string value) => ChainValue("content-" + value);

}
