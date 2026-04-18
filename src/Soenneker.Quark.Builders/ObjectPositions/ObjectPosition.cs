
namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned object-position utility.
/// </summary>
public static class ObjectPosition
{
    /// <summary>
    /// `object-center`
    /// </summary>
    public static ObjectPositionBuilder Center => new(ObjectPositionEnum.Center);

    /// <summary>
    /// `object-top`
    /// </summary>
    public static ObjectPositionBuilder Top => new(ObjectPositionEnum.Top);

    /// <summary>
    /// `object-right`
    /// </summary>
    public static ObjectPositionBuilder Right => new(ObjectPositionEnum.Right);

    /// <summary>
    /// `object-bottom`
    /// </summary>
    public static ObjectPositionBuilder Bottom => new(ObjectPositionEnum.Bottom);

    /// <summary>
    /// `object-left`
    /// </summary>
    public static ObjectPositionBuilder Left => new(ObjectPositionEnum.Left);

    /// <summary>
    /// `object-top-left`
    /// </summary>
    public static ObjectPositionBuilder TopLeft => new(ObjectPositionEnum.TopLeft);

    /// <summary>
    /// `object-top-right`
    /// </summary>
    public static ObjectPositionBuilder TopRight => new(ObjectPositionEnum.TopRight);

    /// <summary>
    /// `object-bottom-left`
    /// </summary>
    public static ObjectPositionBuilder BottomLeft => new(ObjectPositionEnum.BottomLeft);

    /// <summary>
    /// `object-bottom-right`
    /// </summary>
    public static ObjectPositionBuilder BottomRight => new(ObjectPositionEnum.BottomRight);
}
