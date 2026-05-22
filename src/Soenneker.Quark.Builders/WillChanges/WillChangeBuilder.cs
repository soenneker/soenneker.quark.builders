namespace Soenneker.Quark;

[TailwindPrefix("will-change-", Responsive = true)]
public sealed class WillChangeBuilder : FinalClassUtilityBuilder<WillChangeBuilder>
{
    internal WillChangeBuilder() {}
    internal WillChangeBuilder(WillChangeEnum value) : base(value.Value) {}
    internal WillChangeBuilder(string value) : base(value) {}

    public WillChangeBuilder Auto => ChainClass(WillChangeEnum.Auto.Value);
    public WillChangeBuilder Scroll => ChainClass(WillChangeEnum.Scroll.Value);
    public WillChangeBuilder Contents => ChainClass(WillChangeEnum.Contents.Value);
    public WillChangeBuilder Transform => ChainClass(WillChangeEnum.Transform.Value);
    public WillChangeBuilder Token(string value) => ChainClass(value.StartsWith("will-change-") ? value : $"will-change-{value}");
}
