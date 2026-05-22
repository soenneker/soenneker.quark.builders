namespace Soenneker.Quark;

[TailwindModifiers(typeof(BackgroundRepeatBuilder))]
public static partial class BackgroundRepeat
{
    public static BackgroundRepeatBuilder Repeat => new(BackgroundRepeatEnum.Repeat);
    public static BackgroundRepeatBuilder NoRepeat => new(BackgroundRepeatEnum.NoRepeat);
    public static BackgroundRepeatBuilder RepeatX => new(BackgroundRepeatEnum.RepeatX);
    public static BackgroundRepeatBuilder RepeatY => new(BackgroundRepeatEnum.RepeatY);
    public static BackgroundRepeatBuilder RepeatRound => new(BackgroundRepeatEnum.RepeatRound);
    public static BackgroundRepeatBuilder RepeatSpace => new(BackgroundRepeatEnum.RepeatSpace);
    public static BackgroundRepeatBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
