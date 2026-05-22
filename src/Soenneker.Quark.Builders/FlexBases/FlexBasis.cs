namespace Soenneker.Quark;

[TailwindModifiers(typeof(FlexBasisBuilder))]
public static partial class FlexBasis
{
    public static FlexBasisBuilder Auto => new(FlexBasisEnum.Auto);
    public static FlexBasisBuilder Full => new(FlexBasisEnum.Full);
    public static FlexBasisBuilder Is0 => new(FlexBasisEnum.Is0);
    public static FlexBasisBuilder Is1of2 => new(FlexBasisEnum.Is1of2);
    public static FlexBasisBuilder Is1of3 => new(FlexBasisEnum.Is1of3);
    public static FlexBasisBuilder Is2of3 => new(FlexBasisEnum.Is2of3);
    public static FlexBasisBuilder Is1of4 => new(FlexBasisEnum.Is1of4);
    public static FlexBasisBuilder Is3of4 => new(FlexBasisEnum.Is3of4);
    public static FlexBasisBuilder Token(string value) => new(value.StartsWith("basis-") ? value : $"basis-{value}");
}
