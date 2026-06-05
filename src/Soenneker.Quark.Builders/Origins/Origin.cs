namespace Soenneker.Quark;

/// <summary>
/// Represents the origin.
/// </summary>
[TailwindModifiers(typeof(OriginBuilder))]
public static partial class Origin
{
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public static OriginBuilder Center => new(OriginEnum.Center);
    /// <summary>
    /// Gets or sets top.
    /// </summary>
    public static OriginBuilder Top => new(OriginEnum.Top);
    /// <summary>
    /// Gets or sets top right.
    /// </summary>
    public static OriginBuilder TopRight => new(OriginEnum.TopRight);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public static OriginBuilder Right => new(OriginEnum.Right);
    /// <summary>
    /// Gets or sets bottom right.
    /// </summary>
    public static OriginBuilder BottomRight => new(OriginEnum.BottomRight);
    /// <summary>
    /// Gets or sets bottom.
    /// </summary>
    public static OriginBuilder Bottom => new(OriginEnum.Bottom);
    /// <summary>
    /// Gets or sets bottom left.
    /// </summary>
    public static OriginBuilder BottomLeft => new(OriginEnum.BottomLeft);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public static OriginBuilder Left => new(OriginEnum.Left);
    /// <summary>
    /// Gets or sets top left.
    /// </summary>
    public static OriginBuilder TopLeft => new(OriginEnum.TopLeft);
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static OriginBuilder Token(string value) => new("origin-" + value);
}
