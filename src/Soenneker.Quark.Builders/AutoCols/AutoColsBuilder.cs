namespace Soenneker.Quark;

[TailwindPrefix("auto-cols-", Responsive = true)]
public sealed class AutoColsBuilder : FinalClassUtilityBuilder<AutoColsBuilder>
{
    internal AutoColsBuilder()
    {
    }

    internal AutoColsBuilder(AutoColsEnum value, BreakpointType? breakpoint = null) : base(value.Value, breakpoint) {}
    internal AutoColsBuilder(string value, BreakpointType? breakpoint = null) : base(value, breakpoint) {}

    public AutoColsBuilder Auto => ChainClass(AutoColsEnum.AutoValue);
    public AutoColsBuilder Min => ChainClass(AutoColsEnum.MinValue);
    public AutoColsBuilder Max => ChainClass(AutoColsEnum.MaxValue);
    public AutoColsBuilder Fr => ChainClass(AutoColsEnum.FrValue);
    public AutoColsBuilder Token(string value) => ChainClass("auto-cols-" + value);

}
