namespace Soenneker.Quark;

[TailwindModifiers(typeof(BackgroundPositionBuilder))]
public static partial class BackgroundPosition
{
    public static BackgroundPositionBuilder Bottom => new(BackgroundPositionEnum.Bottom);
    public static BackgroundPositionBuilder Center => new(BackgroundPositionEnum.Center);
    public static BackgroundPositionBuilder Left => new(BackgroundPositionEnum.Left);
    public static BackgroundPositionBuilder LeftBottom => new(BackgroundPositionEnum.LeftBottom);
    public static BackgroundPositionBuilder LeftTop => new(BackgroundPositionEnum.LeftTop);
    public static BackgroundPositionBuilder Right => new(BackgroundPositionEnum.Right);
    public static BackgroundPositionBuilder RightBottom => new(BackgroundPositionEnum.RightBottom);
    public static BackgroundPositionBuilder RightTop => new(BackgroundPositionEnum.RightTop);
    public static BackgroundPositionBuilder Top => new(BackgroundPositionEnum.Top);
    public static BackgroundPositionBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
