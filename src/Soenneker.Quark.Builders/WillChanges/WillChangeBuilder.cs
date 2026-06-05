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
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public WillChangeBuilder Token(string value) => ChainClass(value.StartsWith("will-change-") ? value : $"will-change-{value}");
}
