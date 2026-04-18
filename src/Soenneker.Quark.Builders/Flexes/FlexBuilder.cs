namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility builder. Tailwind: flex-1, flex-auto, flex-initial, flex-none.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexBuilder : ResponsiveUtilityBuilder<FlexBuilder>
{
    internal FlexBuilder(FlexEnum value, BreakpointType? breakpoint = null) : base("flex-", value.Value, breakpoint)
    {
    }

    internal FlexBuilder(string value, BreakpointType? breakpoint = null) : base("flex-", value, breakpoint)
    {
    }

    public FlexBuilder Is1 => ChainValue(FlexEnum.Is1.Value);
    public FlexBuilder Auto => ChainValue(FlexEnum.Auto.Value);
    public FlexBuilder Initial => ChainValue(FlexEnum.Initial.Value);
    public FlexBuilder None => ChainValue(FlexEnum.None.Value);
    public FlexBuilder Token(string value) => ChainValue(value);

    public FlexBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public FlexBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public FlexBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public FlexBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public FlexBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public FlexBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
