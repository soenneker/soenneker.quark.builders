namespace Soenneker.Quark;

/// <summary>
/// Represents the touch action builder.
/// </summary>
[TailwindPrefix("touch-", Responsive = true)]
public sealed class TouchActionBuilder : FinalClassUtilityBuilder<TouchActionBuilder>
{
    internal TouchActionBuilder() {}
    internal TouchActionBuilder(TouchActionEnum value) : base(value.Value) {}
    internal TouchActionBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets auto.
    /// </summary>
    public TouchActionBuilder Auto => ChainClass(TouchActionEnum.Auto.Value);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public TouchActionBuilder None => ChainClass(TouchActionEnum.None.Value);
    /// <summary>
    /// Gets or sets pan x.
    /// </summary>
    public TouchActionBuilder PanX => ChainClass(TouchActionEnum.PanX.Value);
    /// <summary>
    /// Gets or sets pan y.
    /// </summary>
    public TouchActionBuilder PanY => ChainClass(TouchActionEnum.PanY.Value);
    /// <summary>
    /// Gets or sets manipulation.
    /// </summary>
    public TouchActionBuilder Manipulation => ChainClass(TouchActionEnum.Manipulation.Value);
    /// <summary>
    /// Adds an arbitrary touch action utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public TouchActionBuilder Token(string value) => ChainClass(value.StartsWith("touch-") ? value : $"touch-{value}");
}
