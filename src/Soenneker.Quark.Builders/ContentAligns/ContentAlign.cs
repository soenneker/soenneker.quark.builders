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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static ContentAlignBuilder Token(string value) => new("content-" + value);
}
