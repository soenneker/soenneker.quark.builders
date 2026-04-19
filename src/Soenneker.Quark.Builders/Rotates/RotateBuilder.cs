namespace Soenneker.Quark;

[TailwindPrefix("rotate-", Responsive = true)]
public sealed class RotateBuilder : ResponsiveUtilityBuilder<RotateBuilder>
{
    internal RotateBuilder(RotateEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal RotateBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public RotateBuilder Is0 => ChainValue(RotateEnum.Is0Value);
    public RotateBuilder Is1 => ChainValue(RotateEnum.Is1Value);
    public RotateBuilder Is2 => ChainValue(RotateEnum.Is2Value);
    public RotateBuilder Is3 => ChainValue(RotateEnum.Is3Value);
    public RotateBuilder Is6 => ChainValue(RotateEnum.Is6Value);
    public RotateBuilder Is12 => ChainValue(RotateEnum.Is12Value);
    public RotateBuilder Is45 => ChainValue(RotateEnum.Is45Value);
    public RotateBuilder Is90 => ChainValue(RotateEnum.Is90Value);
    public RotateBuilder Is180 => ChainValue(RotateEnum.Is180Value);
    public RotateBuilder Token(string value) => ChainValue("rotate-" + value);

    public RotateBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public RotateBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public RotateBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public RotateBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public RotateBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public RotateBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
