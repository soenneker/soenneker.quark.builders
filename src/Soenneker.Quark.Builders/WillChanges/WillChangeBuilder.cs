namespace Soenneker.Quark;

/// <summary>
/// Represents the will change builder.
/// </summary>
[TailwindPrefix("will-change-", Responsive = true)]
public sealed class WillChangeBuilder : FinalClassUtilityBuilder<WillChangeBuilder>
{
    internal WillChangeBuilder() {}
    internal WillChangeBuilder(WillChangeEnum value) : base(value.Value) {}
    internal WillChangeBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public WillChangeBuilder Auto => ChainClass(WillChangeEnum.Auto.Value);
    /// <summary>
    /// Gets or sets scroll.
    /// </summary>
    public WillChangeBuilder Scroll => ChainClass(WillChangeEnum.Scroll.Value);
    /// <summary>
    /// Gets or sets contents.
    /// </summary>
    public WillChangeBuilder Contents => ChainClass(WillChangeEnum.Contents.Value);
    /// <summary>
    /// Gets or sets transform.
    /// </summary>
    public WillChangeBuilder Transform => ChainClass(WillChangeEnum.Transform.Value);
    /// <summary>
    /// Adds an arbitrary will change utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public WillChangeBuilder Token(string value) => ChainClass(value.StartsWith("will-change-") ? value : $"will-change-{value}");
}
