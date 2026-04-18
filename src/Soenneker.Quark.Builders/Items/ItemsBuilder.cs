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

    public ItemsBuilder Start => ChainValue(ItemsEnum.StartValue);
    public ItemsBuilder End => ChainValue(ItemsEnum.EndValue);
    public ItemsBuilder Center => ChainValue(ItemsEnum.CenterValue);
    public ItemsBuilder Baseline => ChainValue(ItemsEnum.BaselineValue);
    public ItemsBuilder Stretch => ChainValue(ItemsEnum.StretchValue);
    public ItemsBuilder Token(string value) => ChainValue(value);

    public ItemsBuilder OnBase => SetPendingBreakpoint(BreakpointType.Base);
    public ItemsBuilder OnSm => SetPendingBreakpoint(BreakpointType.Sm);
    public ItemsBuilder OnMd => SetPendingBreakpoint(BreakpointType.Md);
    public ItemsBuilder OnLg => SetPendingBreakpoint(BreakpointType.Lg);
    public ItemsBuilder OnXl => SetPendingBreakpoint(BreakpointType.Xl);
    public ItemsBuilder On2xl => SetPendingBreakpoint(BreakpointType.Xxl);
}
