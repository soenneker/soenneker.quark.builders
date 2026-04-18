namespace Soenneker.Quark;

[TailwindPrefix("origin-", Responsive = true)]
public sealed class OriginBuilder : ResponsiveUtilityBuilder<OriginBuilder>
{
    internal OriginBuilder(OriginEnum value, BreakpointType? breakpoint = null) : base("origin-", value.Value, breakpoint)
    {
    }

    internal OriginBuilder(string value, BreakpointType? breakpoint = null) : base("origin-", value, breakpoint)
    {
    }

    public OriginBuilder Center => ChainValue(OriginEnum.Center.Value);
    public OriginBuilder Top => ChainValue(OriginEnum.Top.Value);
    public OriginBuilder TopRight => ChainValue(OriginEnum.TopRight.Value);
    public OriginBuilder Right => ChainValue(OriginEnum.Right.Value);
    public OriginBuilder BottomRight => ChainValue(OriginEnum.BottomRight.Value);
    public OriginBuilder Bottom => ChainValue(OriginEnum.Bottom.Value);
    public OriginBuilder BottomLeft => ChainValue(OriginEnum.BottomLeft.Value);
    public OriginBuilder Left => ChainValue(OriginEnum.Left.Value);
    public OriginBuilder TopLeft => ChainValue(OriginEnum.TopLeft.Value);
    public OriginBuilder Token(string value) => ChainValue(value);

    public OriginBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public OriginBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public OriginBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public OriginBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public OriginBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public OriginBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
