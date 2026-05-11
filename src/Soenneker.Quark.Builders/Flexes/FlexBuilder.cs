namespace Soenneker.Quark;

/// <summary>
/// Tailwind flex utility builder. Tailwind: flex-1, flex-auto, flex-initial, flex-none, flex-wrap, flex-row, flex-col.
/// </summary>
[TailwindPrefix("flex-", Responsive = true)]
public sealed class FlexBuilder : ResponsiveUtilityBuilder<FlexBuilder>
{
    internal FlexBuilder()
    {
    }

    internal FlexBuilder(FlexEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal FlexBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public FlexBuilder Is1 => ChainValue(FlexEnum.Is1Value);
    public FlexBuilder Auto => ChainValue(FlexEnum.AutoValue);
    public FlexBuilder Initial => ChainValue(FlexEnum.InitialValue);
    public FlexBuilder None => ChainValue(FlexEnum.NoneValue);
    public FlexBuilder Wrap => ChainValue(FlexEnum.WrapValue);
    public FlexBuilder WrapReverse => ChainValue(FlexEnum.WrapReverseValue);
    public FlexBuilder NoWrap => ChainValue(FlexEnum.NoWrapValue);
    public FlexBuilder Row => ChainValue(FlexEnum.RowValue);
    public FlexBuilder RowReverse => ChainValue(FlexEnum.RowReverseValue);
    public FlexBuilder Col => ChainValue(FlexEnum.ColValue);
    public FlexBuilder ColReverse => ChainValue(FlexEnum.ColReverseValue);
    public FlexBuilder Token(string value) => ChainValue($"flex-{value}");

    public FlexBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public FlexBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public FlexBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public FlexBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public FlexBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public FlexBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
