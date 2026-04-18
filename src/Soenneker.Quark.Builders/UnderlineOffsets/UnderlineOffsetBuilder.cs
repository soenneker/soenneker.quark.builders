namespace Soenneker.Quark;

[TailwindPrefix("underline-offset-", Responsive = true)]
public sealed class UnderlineOffsetBuilder : ResponsiveUtilityBuilder<UnderlineOffsetBuilder>
{
    internal UnderlineOffsetBuilder(UnderlineOffsetEnum value, BreakpointType? breakpoint = null) : base("underline-offset-", value.Value, breakpoint)
    {
    }

    internal UnderlineOffsetBuilder(string value, BreakpointType? breakpoint = null) : base("underline-offset-", value, breakpoint)
    {
    }

    public UnderlineOffsetBuilder Auto => ChainValue(UnderlineOffsetEnum.Auto.Value);
    public UnderlineOffsetBuilder Is0 => ChainValue(UnderlineOffsetEnum.Is0.Value);
    public UnderlineOffsetBuilder Is1 => ChainValue(UnderlineOffsetEnum.Is1.Value);
    public UnderlineOffsetBuilder Is2 => ChainValue(UnderlineOffsetEnum.Is2.Value);
    public UnderlineOffsetBuilder Is4 => ChainValue(UnderlineOffsetEnum.Is4.Value);
    public UnderlineOffsetBuilder Is8 => ChainValue(UnderlineOffsetEnum.Is8.Value);
    public UnderlineOffsetBuilder Token(string value) => ChainValue(value);

    public UnderlineOffsetBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public UnderlineOffsetBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public UnderlineOffsetBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public UnderlineOffsetBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public UnderlineOffsetBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public UnderlineOffsetBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
