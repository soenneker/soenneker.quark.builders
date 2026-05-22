namespace Soenneker.Quark;

[TailwindPrefix("hyphens-", Responsive = true)]
public sealed class HyphenBuilder : FinalClassUtilityBuilder<HyphenBuilder>
{
    internal HyphenBuilder() {}
    internal HyphenBuilder(HyphenEnum value) : base(value.Value) {}
    internal HyphenBuilder(string value) : base(value) {}

    public HyphenBuilder None => ChainClass(HyphenEnum.None.Value);
    public HyphenBuilder Manual => ChainClass(HyphenEnum.Manual.Value);
    public HyphenBuilder Auto => ChainClass(HyphenEnum.Auto.Value);
    public HyphenBuilder Token(string value) => ChainClass(value.StartsWith("hyphens-") ? value : $"hyphens-{value}");
}
