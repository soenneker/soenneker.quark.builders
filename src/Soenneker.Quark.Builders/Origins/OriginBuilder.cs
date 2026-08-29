namespace Soenneker.Quark;

/// <summary>
/// Represents the origin builder.
/// </summary>
[TailwindPrefix("origin-", Responsive = true)]
public sealed class OriginBuilder : ResponsiveUtilityBuilder<OriginBuilder>
{
    internal OriginBuilder()
    {
    }

    internal OriginBuilder(OriginEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal OriginBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public OriginBuilder Center => ChainValue(OriginEnum.CenterValue);
    /// <summary>
    /// Gets or sets top.
    /// </summary>
    public OriginBuilder Top => ChainValue(OriginEnum.TopValue);
    /// <summary>
    /// Gets or sets top right.
    /// </summary>
    public OriginBuilder TopRight => ChainValue(OriginEnum.TopRightValue);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public OriginBuilder Right => ChainValue(OriginEnum.RightValue);
    /// <summary>
    /// Gets or sets bottom right.
    /// </summary>
    public OriginBuilder BottomRight => ChainValue(OriginEnum.BottomRightValue);
    /// <summary>
    /// Gets or sets bottom.
    /// </summary>
    public OriginBuilder Bottom => ChainValue(OriginEnum.BottomValue);
    /// <summary>
    /// Gets or sets bottom left.
    /// </summary>
    public OriginBuilder BottomLeft => ChainValue(OriginEnum.BottomLeftValue);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public OriginBuilder Left => ChainValue(OriginEnum.LeftValue);
    /// <summary>
    /// Gets or sets top left.
    /// </summary>
    public OriginBuilder TopLeft => ChainValue(OriginEnum.TopLeftValue);
    /// <summary>
    /// Adds an arbitrary origin utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OriginBuilder Token(string value) => ChainValue("origin-" + value);

}
