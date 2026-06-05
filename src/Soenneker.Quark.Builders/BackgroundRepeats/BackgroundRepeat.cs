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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static BackgroundRepeatBuilder Token(string value) => new(value.StartsWith("bg-") ? value : $"bg-{value}");
}
