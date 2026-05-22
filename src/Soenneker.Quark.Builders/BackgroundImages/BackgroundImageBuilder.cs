namespace Soenneker.Quark;

[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundImageBuilder : FinalClassUtilityBuilder<BackgroundImageBuilder>
{
    internal BackgroundImageBuilder() {}
    internal BackgroundImageBuilder(BackgroundImageEnum value) : base(value.Value) {}
    internal BackgroundImageBuilder(string value) : base(value) {}

    public BackgroundImageBuilder None => ChainClass(BackgroundImageEnum.None.Value);
    public BackgroundImageBuilder LinearToT => ChainClass(BackgroundImageEnum.LinearToT.Value);
    public BackgroundImageBuilder LinearToR => ChainClass(BackgroundImageEnum.LinearToR.Value);
    public BackgroundImageBuilder LinearToB => ChainClass(BackgroundImageEnum.LinearToB.Value);
    public BackgroundImageBuilder LinearToL => ChainClass(BackgroundImageEnum.LinearToL.Value);
    public BackgroundImageBuilder Radial => ChainClass(BackgroundImageEnum.Radial.Value);
    public BackgroundImageBuilder Conic => ChainClass(BackgroundImageEnum.Conic.Value);
    public BackgroundImageBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
