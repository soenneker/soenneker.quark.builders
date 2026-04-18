namespace Soenneker.Quark;

[TailwindPrefix("auto-rows-", Responsive = true)]
public sealed class AutoRowsBuilder : FinalClassUtilityBuilder<AutoRowsBuilder>
{
    internal AutoRowsBuilder(AutoRowsEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint) {}
    internal AutoRowsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    public AutoRowsBuilder Auto => ChainClass(AutoRowsEnum.AutoValue);
    public AutoRowsBuilder Min => ChainClass(AutoRowsEnum.MinValue);
    public AutoRowsBuilder Max => ChainClass(AutoRowsEnum.MaxValue);
    public AutoRowsBuilder Fr => ChainClass(AutoRowsEnum.FrValue);
    public AutoRowsBuilder Token(string value) => ChainClass("auto-rows-" + value);

    public AutoRowsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public AutoRowsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public AutoRowsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public AutoRowsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public AutoRowsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public AutoRowsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
