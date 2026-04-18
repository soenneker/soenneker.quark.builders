namespace Soenneker.Quark;

[TailwindPrefix("", Responsive = true)]
public sealed class GrowBuilder : ResponsiveUtilityBuilder<GrowBuilder>
{
    internal GrowBuilder(GrowEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal GrowBuilder(string value, BreakpointType? breakpoint = null) : base("", Normalize(value), breakpoint)
    {
    }

    public GrowBuilder Is1 => ChainValue(GrowEnum.Is1.Value);
    public GrowBuilder Is0 => ChainValue(GrowEnum.Is0.Value);
    public GrowBuilder Token(string value) => ChainValue(Normalize(value));

    public GrowBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public GrowBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public GrowBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public GrowBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public GrowBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public GrowBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    private static string Normalize(string value)
    {
        return value switch
        {
            "1" => GrowEnum.Is1Value,
            "0" => GrowEnum.Is0Value,
            _ when value.StartsWith("grow") => value,
            _ => "grow-" + value
        };
    }
}
