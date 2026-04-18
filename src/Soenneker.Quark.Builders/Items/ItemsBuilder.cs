namespace Soenneker.Quark;

[TailwindPrefix("items-", Responsive = true)]
public sealed class ItemsBuilder : ResponsiveUtilityBuilder<ItemsBuilder>
{
    internal ItemsBuilder(ItemsEnum value, BreakpointType? breakpoint = null) : base("items-", value.Value, breakpoint)
    {
    }

    internal ItemsBuilder(string value, BreakpointType? breakpoint = null) : base("items-", value, breakpoint)
    {
    }

    public ItemsBuilder Start => ChainValue(ItemsEnum.Start.Value);
    public ItemsBuilder End => ChainValue(ItemsEnum.End.Value);
    public ItemsBuilder Center => ChainValue(ItemsEnum.Center.Value);
    public ItemsBuilder Baseline => ChainValue(ItemsEnum.Baseline.Value);
    public ItemsBuilder Stretch => ChainValue(ItemsEnum.Stretch.Value);
    public ItemsBuilder Token(string value) => ChainValue(value);

    public ItemsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ItemsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ItemsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ItemsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ItemsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ItemsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
