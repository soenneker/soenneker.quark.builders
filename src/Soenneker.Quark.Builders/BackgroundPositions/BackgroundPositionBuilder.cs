namespace Soenneker.Quark;

[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundPositionBuilder : FinalClassUtilityBuilder<BackgroundPositionBuilder>
{
    internal BackgroundPositionBuilder() {}
    internal BackgroundPositionBuilder(BackgroundPositionEnum value) : base(value.Value) {}
    internal BackgroundPositionBuilder(string value) : base(value) {}

    public BackgroundPositionBuilder Bottom => ChainClass(BackgroundPositionEnum.Bottom.Value);
    public BackgroundPositionBuilder Center => ChainClass(BackgroundPositionEnum.Center.Value);
    public BackgroundPositionBuilder Left => ChainClass(BackgroundPositionEnum.Left.Value);
    public BackgroundPositionBuilder LeftBottom => ChainClass(BackgroundPositionEnum.LeftBottom.Value);
    public BackgroundPositionBuilder LeftTop => ChainClass(BackgroundPositionEnum.LeftTop.Value);
    public BackgroundPositionBuilder Right => ChainClass(BackgroundPositionEnum.Right.Value);
    public BackgroundPositionBuilder RightBottom => ChainClass(BackgroundPositionEnum.RightBottom.Value);
    public BackgroundPositionBuilder RightTop => ChainClass(BackgroundPositionEnum.RightTop.Value);
    public BackgroundPositionBuilder Top => ChainClass(BackgroundPositionEnum.Top.Value);
    public BackgroundPositionBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
