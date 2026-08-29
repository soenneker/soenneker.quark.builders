namespace Soenneker.Quark;

/// <summary>
/// Represents the background repeat builder.
/// </summary>
[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundRepeatBuilder : FinalClassUtilityBuilder<BackgroundRepeatBuilder>
{
    internal BackgroundRepeatBuilder() {}
    internal BackgroundRepeatBuilder(BackgroundRepeatEnum value) : base(value.Value) {}
    internal BackgroundRepeatBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets repeat.
    /// </summary>
    public BackgroundRepeatBuilder Repeat => ChainClass(BackgroundRepeatEnum.Repeat.Value);
    /// <summary>
    /// Gets or sets no repeat.
    /// </summary>
    public BackgroundRepeatBuilder NoRepeat => ChainClass(BackgroundRepeatEnum.NoRepeat.Value);
    /// <summary>
    /// Gets or sets repeat x.
    /// </summary>
    public BackgroundRepeatBuilder RepeatX => ChainClass(BackgroundRepeatEnum.RepeatX.Value);
    /// <summary>
    /// Gets or sets repeat y.
    /// </summary>
    public BackgroundRepeatBuilder RepeatY => ChainClass(BackgroundRepeatEnum.RepeatY.Value);
    /// <summary>
    /// Gets or sets repeat round.
    /// </summary>
    public BackgroundRepeatBuilder RepeatRound => ChainClass(BackgroundRepeatEnum.RepeatRound.Value);
    /// <summary>
    /// Gets or sets repeat space.
    /// </summary>
    public BackgroundRepeatBuilder RepeatSpace => ChainClass(BackgroundRepeatEnum.RepeatSpace.Value);
    /// <summary>
    /// Adds an arbitrary background repeat utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BackgroundRepeatBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
