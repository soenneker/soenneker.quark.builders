namespace Soenneker.Quark;

/// <summary>
/// Represents the clear builder.
/// </summary>
[TailwindPrefix("clear-", Responsive = true)]
public sealed class ClearBuilder : FinalClassUtilityBuilder<ClearBuilder>
{
    internal ClearBuilder() {}
    internal ClearBuilder(ClearEnum value) : base(value.Value) {}
    internal ClearBuilder(string value) : base(value) {}

    /// <summary>
    /// Gets or sets start.
    /// </summary>
    public ClearBuilder Start => ChainClass(ClearEnum.Start.Value);
    /// <summary>
    /// Gets or sets end.
    /// </summary>
    public ClearBuilder End => ChainClass(ClearEnum.End.Value);
    /// <summary>
    /// Gets or sets left.
    /// </summary>
    public ClearBuilder Left => ChainClass(ClearEnum.Left.Value);
    /// <summary>
    /// Gets or sets right.
    /// </summary>
    public ClearBuilder Right => ChainClass(ClearEnum.Right.Value);
    /// <summary>
    /// Gets or sets both.
    /// </summary>
    public ClearBuilder Both => ChainClass(ClearEnum.Both.Value);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public ClearBuilder None => ChainClass(ClearEnum.None.Value);
    /// <summary>
    /// Adds an arbitrary clear utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public ClearBuilder Token(string value) => ChainClass(value.StartsWith("clear-") ? value : $"clear-{value}");
}
