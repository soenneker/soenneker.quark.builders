namespace Soenneker.Quark;

[TailwindPrefix("forced-color-adjust-", Responsive = true)]
public sealed class ForcedColorAdjustBuilder : FinalClassUtilityBuilder<ForcedColorAdjustBuilder>
{
    internal ForcedColorAdjustBuilder() {}
    internal ForcedColorAdjustBuilder(ForcedColorAdjustEnum value) : base(value.Value) {}
    internal ForcedColorAdjustBuilder(string value) : base(value) {}

    public ForcedColorAdjustBuilder Auto => ChainClass(ForcedColorAdjustEnum.Auto.Value);
    public ForcedColorAdjustBuilder None => ChainClass(ForcedColorAdjustEnum.None.Value);
    public ForcedColorAdjustBuilder Token(string value) => ChainClass(value.StartsWith("forced-color-adjust-") ? value : $"forced-color-adjust-{value}");
}
