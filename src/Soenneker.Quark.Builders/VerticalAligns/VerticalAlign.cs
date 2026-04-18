namespace Soenneker.Quark;

/// <summary>
/// Static utility class for creating vertical align builders with predefined values.
/// </summary>
public static class VerticalAlign
{
    /// <summary>
    /// Gets a vertical align builder with baseline alignment.
    /// </summary>
    public static VerticalAlignBuilder Baseline => new(VerticalAlignEnum.Baseline);
    /// <summary>
    /// Gets a vertical align builder with top alignment.
    /// </summary>
    public static VerticalAlignBuilder Top => new(VerticalAlignEnum.Top);
    /// <summary>
    /// Gets a vertical align builder with middle alignment.
    /// </summary>
    public static VerticalAlignBuilder Middle => new(VerticalAlignEnum.Middle);
    /// <summary>
    /// Gets a vertical align builder with bottom alignment.
    /// </summary>
    public static VerticalAlignBuilder Bottom => new(VerticalAlignEnum.Bottom);
    /// <summary>
    /// Gets a vertical align builder with text-top alignment.
    /// </summary>
    public static VerticalAlignBuilder TextTop => new(VerticalAlignEnum.TextTop);
    /// <summary>
    /// Gets a vertical align builder with text-bottom alignment.
    /// </summary>
    public static VerticalAlignBuilder TextBottom => new(VerticalAlignEnum.TextBottom);
}
