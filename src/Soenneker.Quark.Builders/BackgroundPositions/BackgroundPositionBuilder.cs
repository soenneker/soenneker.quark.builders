namespace Soenneker.Quark;

/// <summary>
/// Represents the background position builder.
/// </summary>
[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundPositionBuilder : FinalClassUtilityBuilder<BackgroundPositionBuilder>
{
    internal BackgroundPositionBuilder() {}
    internal BackgroundPositionBuilder(BackgroundPositionEnum value) : base(value.Value) {}
    internal BackgroundPositionBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets bottom.
    /// </summary>
    public BackgroundPositionBuilder Bottom => ChainClass(BackgroundPositionEnum.Bottom.Value);
    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public BackgroundPositionBuilder Center => ChainClass(BackgroundPositionEnum.Center.Value);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public BackgroundPositionBuilder Left => ChainClass(BackgroundPositionEnum.Left.Value);
    /// <summary>
    /// Gets or sets left bottom.
    /// </summary>
    public BackgroundPositionBuilder LeftBottom => ChainClass(BackgroundPositionEnum.LeftBottom.Value);
    /// <summary>
    /// Gets or sets left top.
    /// </summary>
    public BackgroundPositionBuilder LeftTop => ChainClass(BackgroundPositionEnum.LeftTop.Value);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public BackgroundPositionBuilder Right => ChainClass(BackgroundPositionEnum.Right.Value);
    /// <summary>
    /// Gets or sets right bottom.
    /// </summary>
    public BackgroundPositionBuilder RightBottom => ChainClass(BackgroundPositionEnum.RightBottom.Value);
    /// <summary>
    /// Gets or sets right top.
    /// </summary>
    public BackgroundPositionBuilder RightTop => ChainClass(BackgroundPositionEnum.RightTop.Value);
    /// <summary>
    /// Gets or sets top.
    /// </summary>
    public BackgroundPositionBuilder Top => ChainClass(BackgroundPositionEnum.Top.Value);
    /// <summary>
    /// Adds an arbitrary background position utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BackgroundPositionBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
