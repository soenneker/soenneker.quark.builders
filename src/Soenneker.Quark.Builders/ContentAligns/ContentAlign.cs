namespace Soenneker.Quark;

/// <summary>
/// Represents the content align.
/// </summary>
[TailwindModifiers(typeof(ContentAlignBuilder))]
public static partial class ContentAlign
{
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public static ContentAlignBuilder Normal => new(ContentEnum.Normal);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static ContentAlignBuilder Center => new(ContentEnum.Center);
    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public static ContentAlignBuilder Start => new(ContentEnum.Start);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public static ContentAlignBuilder End => new(ContentEnum.End);
    /// <summary>
    /// Gets or sets between.
    /// </summary>
    public static ContentAlignBuilder Between => new(ContentEnum.Between);
    /// <summary>
    /// Gets or sets around.
    /// </summary>
    public static ContentAlignBuilder Around => new(ContentEnum.Around);
    /// <summary>
    /// Gets or sets evenly.
    /// </summary>
    public static ContentAlignBuilder Evenly => new(ContentEnum.Evenly);
    /// <summary>
    /// Gets or sets stretch.
    /// </summary>
    public static ContentAlignBuilder Stretch => new(ContentEnum.Stretch);
    /// <summary>
    /// Gets or sets baseline.
    /// </summary>
    public static ContentAlignBuilder Baseline => new(ContentEnum.Baseline);
    /// <summary>
    /// Adds an arbitrary content align utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ContentAlignBuilder Token(string value) => new("content-" + value);
}
