namespace Soenneker.Quark;

/// <summary>
/// Represents the background repeat.
/// </summary>
[TailwindModifiers(typeof(BackgroundRepeatBuilder))]
public static partial class BackgroundRepeat
{
    /// <summary>
    /// Gets or sets repeat.
    /// </summary>
    public static BackgroundRepeatBuilder Repeat => new(BackgroundRepeatEnum.Repeat);
    /// <summary>
    /// Gets or sets no repeat.
    /// </summary>
    public static BackgroundRepeatBuilder NoRepeat => new(BackgroundRepeatEnum.NoRepeat);
    /// <summary>
    /// Gets or sets repeat x.
    /// </summary>
    public static BackgroundRepeatBuilder RepeatX => new(BackgroundRepeatEnum.RepeatX);
    /// <summary>
    /// Gets or sets repeat y.
    /// </summary>
    public static BackgroundRepeatBuilder RepeatY => new(BackgroundRepeatEnum.RepeatY);
    /// <summary>
    /// Gets or sets repeat round.
    /// </summary>
    public static BackgroundRepeatBuilder RepeatRound => new(BackgroundRepeatEnum.RepeatRound);
    /// <summary>
    /// Gets or sets repeat space.
    /// </summary>
    public static BackgroundRepeatBuilder RepeatSpace => new(BackgroundRepeatEnum.RepeatSpace);
    /// <summary>
    /// Adds an arbitrary background repeat utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static BackgroundRepeatBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
