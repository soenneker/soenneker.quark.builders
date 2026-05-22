namespace Soenneker.Quark;

[TailwindPrefix("wrap-", Responsive = true)]
public sealed class OverflowWrapBuilder : FinalClassUtilityBuilder<OverflowWrapBuilder>
{
    internal OverflowWrapBuilder() {}
    internal OverflowWrapBuilder(OverflowWrapEnum value) : base(value.Value) {}
    internal OverflowWrapBuilder(string value) : base(value) {}

    public OverflowWrapBuilder Normal => ChainClass(OverflowWrapEnum.Normal.Value);
    public OverflowWrapBuilder Anywhere => ChainClass(OverflowWrapEnum.Anywhere.Value);
    public OverflowWrapBuilder BreakWord => ChainClass(OverflowWrapEnum.BreakWord.Value);
    public OverflowWrapBuilder Token(string value) => ChainClass(value.StartsWith("wrap-") ? value : $"wrap-{value}");
}
