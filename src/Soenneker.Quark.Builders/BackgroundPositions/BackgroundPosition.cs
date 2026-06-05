namespace Soenneker.Quark;

/// <summary>
/// Represents the background position.
/// </summary>
[TailwindModifiers(typeof(BackgroundPositionBuilder))]
public static partial class BackgroundPosition
{
    /// <summary>
    /// Gets or sets bottom.
    /// </summary>
    public static BackgroundPositionBuilder Bottom => new(BackgroundPositionEnum.Bottom);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static BackgroundPositionBuilder Center => new(BackgroundPositionEnum.Center);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public static BackgroundPositionBuilder Left => new(BackgroundPositionEnum.Left);
    /// <summary>
    /// Gets or sets left bottom.
    /// </summary>
    public static BackgroundPositionBuilder LeftBottom => new(BackgroundPositionEnum.LeftBottom);
    /// <summary>
    /// Gets or sets left top.
    /// </summary>
    public static BackgroundPositionBuilder LeftTop => new(BackgroundPositionEnum.LeftTop);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public static BackgroundPositionBuilder Right => new(BackgroundPositionEnum.Right);
    /// <summary>
    /// Gets or sets right bottom.
    /// </summary>
    public static BackgroundPositionBuilder RightBottom => new(BackgroundPositionEnum.RightBottom);
    /// <summary>
    /// Gets or sets right top.
    /// </summary>
    public static BackgroundPositionBuilder RightTop => new(BackgroundPositionEnum.RightTop);
    /// <summary>
    /// Gets or sets top.
    /// </summary>
    public static BackgroundPositionBuilder Top => new(BackgroundPositionEnum.Top);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static BackgroundPositionBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
