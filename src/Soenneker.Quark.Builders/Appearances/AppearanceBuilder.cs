namespace Soenneker.Quark;

[TailwindPrefix("appearance-", Responsive = true)]
public sealed class AppearanceBuilder : FinalClassUtilityBuilder<AppearanceBuilder>
{
    internal AppearanceBuilder() {}
    internal AppearanceBuilder(AppearanceEnum value) : base(value.Value) {}
    internal AppearanceBuilder(string value) : base(value) {}

    public AppearanceBuilder None => ChainClass(AppearanceEnum.None.Value);
    public AppearanceBuilder Auto => ChainClass(AppearanceEnum.Auto.Value);
    public AppearanceBuilder Token(string value) => ChainClass(value.StartsWith("appearance-") ? value : $"appearance-{value}");
}
