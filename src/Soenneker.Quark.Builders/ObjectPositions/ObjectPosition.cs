
namespace Soenneker.Quark;

/// <summary>
/// Tailwind/shadcn-aligned object-position utility.
/// </summary>
[TailwindModifiers(typeof(ObjectPositionBuilder))]
public static partial class ObjectPosition
{
    /// <summary>
    /// `object-center`
    /// </summary>
    public static ObjectPositionBuilder Center => new(ObjectPositionEnum.CenterValue);

    /// <summary>
    /// `object-top`
    /// </summary>
    public static ObjectPositionBuilder Top => new(ObjectPositionEnum.TopValue);

    /// <summary>
    /// `object-right`
    /// </summary>
    public static ObjectPositionBuilder Right => new(ObjectPositionEnum.RightValue);

    /// <summary>
    /// `object-bottom`
    /// </summary>
    public static ObjectPositionBuilder Bottom => new(ObjectPositionEnum.BottomValue);

    /// <summary>
    /// `object-left`
    /// </summary>
    public static ObjectPositionBuilder Left => new(ObjectPositionEnum.LeftValue);

    /// <summary>
    /// `object-top-left`
    /// </summary>
    public static ObjectPositionBuilder TopLeft => new(ObjectPositionEnum.TopLeftValue);

    /// <summary>
    /// `object-top-right`
    /// </summary>
    public static ObjectPositionBuilder TopRight => new(ObjectPositionEnum.TopRightValue);

    /// <summary>
    /// `object-bottom-left`
    /// </summary>
    public static ObjectPositionBuilder BottomLeft => new(ObjectPositionEnum.BottomLeftValue);

    /// <summary>
    /// `object-bottom-right`
    /// </summary>
    public static ObjectPositionBuilder BottomRight => new(ObjectPositionEnum.BottomRightValue);
}
