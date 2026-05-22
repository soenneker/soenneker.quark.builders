namespace Soenneker.Quark;

[TailwindPrefix("basis-", Responsive = true)]
public sealed class FlexBasisBuilder : FinalClassUtilityBuilder<FlexBasisBuilder>
{
    internal FlexBasisBuilder() {}
    internal FlexBasisBuilder(FlexBasisEnum value) : base(value.Value) {}
    internal FlexBasisBuilder(string value) : base(value) {}

    public FlexBasisBuilder Auto => ChainClass(FlexBasisEnum.Auto.Value);
    public FlexBasisBuilder Full => ChainClass(FlexBasisEnum.Full.Value);
    public FlexBasisBuilder Is0 => ChainClass(FlexBasisEnum.Is0.Value);
    public FlexBasisBuilder Is1of2 => ChainClass(FlexBasisEnum.Is1of2.Value);
    public FlexBasisBuilder Is1of3 => ChainClass(FlexBasisEnum.Is1of3.Value);
    public FlexBasisBuilder Is2of3 => ChainClass(FlexBasisEnum.Is2of3.Value);
    public FlexBasisBuilder Is1of4 => ChainClass(FlexBasisEnum.Is1of4.Value);
    public FlexBasisBuilder Is3of4 => ChainClass(FlexBasisEnum.Is3of4.Value);
    public FlexBasisBuilder Token(string value) => ChainClass(value.StartsWith("basis-") ? value : $"basis-{value}");
}
