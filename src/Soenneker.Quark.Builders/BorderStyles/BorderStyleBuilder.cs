namespace Soenneker.Quark;

[TailwindPrefix("border-", Responsive = true)]
public sealed class BorderStyleBuilder : FinalClassUtilityBuilder<BorderStyleBuilder>
{
    internal BorderStyleBuilder() {}
    internal BorderStyleBuilder(BorderStyleEnum value) : base(value.Value) {}
    internal BorderStyleBuilder(string value) : base(value) {}

    public BorderStyleBuilder Solid => ChainClass(BorderStyleEnum.Solid.Value);
    public BorderStyleBuilder Dashed => ChainClass(BorderStyleEnum.Dashed.Value);
    public BorderStyleBuilder Dotted => ChainClass(BorderStyleEnum.Dotted.Value);
    public BorderStyleBuilder Double => ChainClass(BorderStyleEnum.Double.Value);
    public BorderStyleBuilder Hidden => ChainClass(BorderStyleEnum.Hidden.Value);
    public BorderStyleBuilder None => ChainClass(BorderStyleEnum.None.Value);
    public BorderStyleBuilder Token(string value) => ChainClass(value.StartsWith("border-") ? value : $"border-{value}");
}
