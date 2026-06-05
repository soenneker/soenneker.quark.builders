namespace Soenneker.Quark;

/// <summary>
/// Represents the tracking.
/// </summary>
[TailwindModifiers(typeof(TrackingBuilder))]
public static partial class Tracking
{
    /// <summary>
    /// Gets or sets tighter.
    /// </summary>
    public static TrackingBuilder Tighter => new(TrackingEnum.Tighter);
    /// <summary>
    /// Gets or sets tight.
    /// </summary>
    public static TrackingBuilder Tight => new(TrackingEnum.Tight);
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public static TrackingBuilder Normal => new(TrackingEnum.Normal);
    /// <summary>
    /// Gets or sets wide.
    /// </summary>
    public static TrackingBuilder Wide => new(TrackingEnum.Wide);
    /// <summary>
    /// Gets or sets wider.
    /// </summary>
    public static TrackingBuilder Wider => new(TrackingEnum.Wider);
    /// <summary>
    /// Gets or sets widest.
    /// </summary>
    public static TrackingBuilder Widest => new(TrackingEnum.Widest);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static TrackingBuilder Token(string value) => new("tracking-" + value);
}
