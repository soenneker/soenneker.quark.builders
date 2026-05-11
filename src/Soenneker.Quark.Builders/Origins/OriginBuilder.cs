namespace Soenneker.Quark;

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

    public OriginBuilder Center => ChainValue(OriginEnum.CenterValue);
    public OriginBuilder Top => ChainValue(OriginEnum.TopValue);
    public OriginBuilder TopRight => ChainValue(OriginEnum.TopRightValue);
    public OriginBuilder Right => ChainValue(OriginEnum.RightValue);
    public OriginBuilder BottomRight => ChainValue(OriginEnum.BottomRightValue);
    public OriginBuilder Bottom => ChainValue(OriginEnum.BottomValue);
    public OriginBuilder BottomLeft => ChainValue(OriginEnum.BottomLeftValue);
    public OriginBuilder Left => ChainValue(OriginEnum.LeftValue);
    public OriginBuilder TopLeft => ChainValue(OriginEnum.TopLeftValue);
    public OriginBuilder Token(string value) => ChainValue("origin-" + value);

    public OriginBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public OriginBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public OriginBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public OriginBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public OriginBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public OriginBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
