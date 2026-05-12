namespace Soenneker.Quark;

[TailwindPrefix("ease-", Responsive = true)]
public sealed class EaseBuilder : ResponsiveUtilityBuilder<EaseBuilder>
{
    internal EaseBuilder()
    {
    }

    internal EaseBuilder(EaseEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal EaseBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public EaseBuilder Linear => ChainValue(EaseEnum.LinearValue);
    public EaseBuilder In => ChainValue(EaseEnum.InValue);
    public EaseBuilder Out => ChainValue(EaseEnum.OutValue);
    public EaseBuilder InOut => ChainValue(EaseEnum.InOutValue);
    public EaseBuilder Token(string value) => ChainValue("ease-" + value);

}
