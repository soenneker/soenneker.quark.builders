namespace Soenneker.Quark;

/// <summary>
/// Represents the background size builder.
/// </summary>
[TailwindPrefix("bg-", Responsive = true)]
public sealed class BackgroundSizeBuilder : FinalClassUtilityBuilder<BackgroundSizeBuilder>
{
    internal BackgroundSizeBuilder() {}
    internal BackgroundSizeBuilder(BackgroundSizeEnum value) : base(value.Value) {}
    internal BackgroundSizeBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public BackgroundSizeBuilder Auto => ChainClass(BackgroundSizeEnum.Auto.Value);
    /// <summary>
    /// Gets or sets cover.
    /// </summary>
    public BackgroundSizeBuilder Cover => ChainClass(BackgroundSizeEnum.Cover.Value);
    /// <summary>
    /// Gets or sets contain.
    /// </summary>
    public BackgroundSizeBuilder Contain => ChainClass(BackgroundSizeEnum.Contain.Value);
    /// <summary>
    /// Adds an arbitrary background size utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public BackgroundSizeBuilder Token(string value) => ChainClass(value.StartsWith("bg-") ? value : $"bg-{value}");
}
