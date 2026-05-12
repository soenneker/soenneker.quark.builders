namespace Soenneker.Quark;

[TailwindPrefix("auto-rows-", Responsive = true)]
public sealed class AutoRowsBuilder : FinalClassUtilityBuilder<AutoRowsBuilder>
{
    internal AutoRowsBuilder()
    {
    }

    internal AutoRowsBuilder(AutoRowsEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint) {}
    internal AutoRowsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    public AutoRowsBuilder Auto => ChainClass(AutoRowsEnum.AutoValue);
    public AutoRowsBuilder Min => ChainClass(AutoRowsEnum.MinValue);
    public AutoRowsBuilder Max => ChainClass(AutoRowsEnum.MaxValue);
    public AutoRowsBuilder Fr => ChainClass(AutoRowsEnum.FrValue);
    public AutoRowsBuilder Token(string value) => ChainClass("auto-rows-" + value);

}
