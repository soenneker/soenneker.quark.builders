namespace Soenneker.Quark;

/// <summary>
/// Represents the content align builder.
/// </summary>
[TailwindPrefix("content-", Responsive = true)]
public sealed class ContentAlignBuilder : FinalClassUtilityBuilder<ContentAlignBuilder>
{
    internal ContentAlignBuilder()
    {
    }

    internal ContentAlignBuilder(ContentEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal ContentAlignBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public ContentAlignBuilder Normal => ChainClass(ContentEnum.NormalValue);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public ContentAlignBuilder Center => ChainClass(ContentEnum.CenterValue);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public ContentAlignBuilder Start => ChainClass(ContentEnum.StartValue);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public ContentAlignBuilder End => ChainClass(ContentEnum.EndValue);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public ContentAlignBuilder Between => ChainClass(ContentEnum.BetweenValue);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public ContentAlignBuilder Around => ChainClass(ContentEnum.AroundValue);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public ContentAlignBuilder Evenly => ChainClass(ContentEnum.EvenlyValue);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public ContentAlignBuilder Stretch => ChainClass(ContentEnum.StretchValue);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public ContentAlignBuilder Baseline => ChainClass(ContentEnum.BaselineValue);
    /// <summary>
    /// Adds an arbitrary content align utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ContentAlignBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "content-"));

}
