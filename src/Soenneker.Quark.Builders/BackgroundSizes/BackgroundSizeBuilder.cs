namespace Soenneker.Quark;

[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundSizeBuilder : FinalClassUtilityBuilder<BackgroundSizeBuilder>
{
    internal BackgroundSizeBuilder() {}
    internal BackgroundSizeBuilder(BackgroundSizeEnum value) : base(value.Value) {}
    internal BackgroundSizeBuilder(string value) : base(value) {}

    public BackgroundSizeBuilder Auto => ChainClass(BackgroundSizeEnum.Auto.Value);
    public BackgroundSizeBuilder Cover => ChainClass(BackgroundSizeEnum.Cover.Value);
    public BackgroundSizeBuilder Contain => ChainClass(BackgroundSizeEnum.Contain.Value);
    public BackgroundSizeBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
