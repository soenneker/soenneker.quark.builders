namespace Soenneker.Quark;

/// <summary>
/// Represents the order builder.
/// </summary>
[TailwindPrefix("order-", Responsive = true)]
public sealed class OrderBuilder : FinalClassUtilityBuilder<OrderBuilder>
{
    internal OrderBuilder()
    {
    }

    internal OrderBuilder(OrderEnum value) : base(value.Value)
    {
    }

    internal OrderBuilder(string value) : base(value)
    {
    }

    /// <summary>
    /// Gets or sets first.
    /// </summary>
    public OrderBuilder First => ChainClass(OrderEnum.First.Value);
    /// <summary>
    /// Gets or sets last.
    /// </summary>
    public OrderBuilder Last => ChainClass(OrderEnum.Last.Value);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public OrderBuilder None => ChainClass(OrderEnum.None.Value);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public OrderBuilder Is1 => ChainClass(OrderEnum.Is1.Value);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public OrderBuilder Is12 => ChainClass(OrderEnum.Is12.Value);
    /// <summary>
    /// Adds the at Order utility to the class list.
    /// </summary>
    /// <param name="value">CSS value used to construct the utility class.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OrderBuilder At(int value) => ChainClass($"order-{value}");
    /// <summary>
    /// Adds an arbitrary order utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public OrderBuilder Token(string value) => ChainClass(value.StartsWith("order-") ? value : $"order-{value}");
}
