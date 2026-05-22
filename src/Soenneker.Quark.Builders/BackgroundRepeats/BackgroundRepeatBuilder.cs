namespace Soenneker.Quark;

[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundRepeatBuilder : FinalClassUtilityBuilder<BackgroundRepeatBuilder>
{
    internal BackgroundRepeatBuilder() {}
    internal BackgroundRepeatBuilder(BackgroundRepeatEnum value) : base(value.Value) {}
    internal BackgroundRepeatBuilder(string value) : base(value) {}

    public BackgroundRepeatBuilder Repeat => ChainClass(BackgroundRepeatEnum.Repeat.Value);
    public BackgroundRepeatBuilder NoRepeat => ChainClass(BackgroundRepeatEnum.NoRepeat.Value);
    public BackgroundRepeatBuilder RepeatX => ChainClass(BackgroundRepeatEnum.RepeatX.Value);
    public BackgroundRepeatBuilder RepeatY => ChainClass(BackgroundRepeatEnum.RepeatY.Value);
    public BackgroundRepeatBuilder RepeatRound => ChainClass(BackgroundRepeatEnum.RepeatRound.Value);
    public BackgroundRepeatBuilder RepeatSpace => ChainClass(BackgroundRepeatEnum.RepeatSpace.Value);
    public BackgroundRepeatBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
