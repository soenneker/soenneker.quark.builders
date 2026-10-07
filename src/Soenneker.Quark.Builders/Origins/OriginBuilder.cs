namespace Soenneker.Quark;

/// <summary>
/// Represents the origin builder.
/// </summary>
[TailwindPrefix("origin-", Responsive = true)]
public sealed class OriginBuilder : FinalClassUtilityBuilder<OriginBuilder>
{
    internal OriginBuilder()
    {
    }

    internal OriginBuilder(OriginEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint)
    {
    }

    internal OriginBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint)
    {
    }

    /// <summary>
    /// Gets or sets center.
    /// </summary>
    public OriginBuilder Center => ChainClass(OriginEnum.CenterValue);
    /// <summary>
    /// Gets or sets top.
    /// </summary>
    public OriginBuilder Top => ChainClass(OriginEnum.TopValue);
    /// <summary>
    /// Gets or sets top right.
    /// </summary>
    public OriginBuilder TopRight => ChainClass(OriginEnum.TopRightValue);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public OriginBuilder Right => ChainClass(OriginEnum.RightValue);
    /// <summary>
    /// Gets or sets bottom right.
    /// </summary>
    public OriginBuilder BottomRight => ChainClass(OriginEnum.BottomRightValue);
    /// <summary>
    /// Gets or sets bottom.
    /// </summary>
    public OriginBuilder Bottom => ChainClass(OriginEnum.BottomValue);
    /// <summary>
    /// Gets or sets bottom left.
    /// </summary>
    public OriginBuilder BottomLeft => ChainClass(OriginEnum.BottomLeftValue);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public OriginBuilder Left => ChainClass(OriginEnum.LeftValue);
    /// <summary>
    /// Gets or sets top left.
    /// </summary>
    public OriginBuilder TopLeft => ChainClass(OriginEnum.TopLeftValue);
    /// <summary>
    /// Adds an arbitrary origin utility token to the class list.
    /// </summary>
    /// <param name="value">Utility suffix, without the family prefix. Apply variants with fluent modifiers.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OriginBuilder Token(string value) => ChainClass(UtilityToken.WithPrefix(value, "origin-"));

}
