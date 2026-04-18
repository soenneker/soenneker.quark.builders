namespace Soenneker.Quark;

[TailwindPrefix("", Responsive = true)]
public sealed class ShrinkBuilder : ResponsiveUtilityBuilder<ShrinkBuilder>
{
    internal ShrinkBuilder(ShrinkEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal ShrinkBuilder(string value, BreakpointType? breakpoint = null) : base("", Normalize(value), breakpoint)
    {
    }

    public ShrinkBuilder Is1 => ChainValue(ShrinkEnum.Is1.Value);
    public ShrinkBuilder Is0 => ChainValue(ShrinkEnum.Is0.Value);
    public ShrinkBuilder Token(string value) => ChainValue(Normalize(value));

    public ShrinkBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ShrinkBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ShrinkBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ShrinkBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ShrinkBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ShrinkBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);

    private static string Normalize(string value)
    {
        return value switch
        {
            "1" => ShrinkEnum.Is1Value,
            "0" => ShrinkEnum.Is0Value,
            _ when value.StartsWith("shrink") => value,
            _ => "shrink-" + value
        };
    }
}
