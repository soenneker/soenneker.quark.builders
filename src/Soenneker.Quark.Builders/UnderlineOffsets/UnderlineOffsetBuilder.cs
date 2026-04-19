namespace Soenneker.Quark;

[TailwindPrefix("underline-offset-", Responsive = true)]
public sealed class UnderlineOffsetBuilder : ResponsiveUtilityBuilder<UnderlineOffsetBuilder>
{
    internal UnderlineOffsetBuilder(UnderlineOffsetEnum value, BreakpointType? breakpoint = null) : base("", value.Value, breakpoint)
    {
    }

    internal UnderlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base("", value, breakpoint)
    {
    }

    public UnderlineOffsetBuilder Auto => ChainValue(UnderlineOffsetEnum.AutoValue);
    public UnderlineOffsetBuilder Is0 => ChainValue(UnderlineOffsetEnum.Is0Value);
    public UnderlineOffsetBuilder Is1 => ChainValue(UnderlineOffsetEnum.Is1Value);
    public UnderlineOffsetBuilder Is2 => ChainValue(UnderlineOffsetEnum.Is2Value);
    public UnderlineOffsetBuilder Is4 => ChainValue(UnderlineOffsetEnum.Is4Value);
    public UnderlineOffsetBuilder Is8 => ChainValue(UnderlineOffsetEnum.Is8Value);
    public UnderlineOffsetBuilder Token(string value) => ChainValue("underline-offset-" + value);

    public UnderlineOffsetBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public UnderlineOffsetBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public UnderlineOffsetBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public UnderlineOffsetBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public UnderlineOffsetBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public UnderlineOffsetBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
