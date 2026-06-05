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
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public OrderBuilder At(int value) => ChainClass($"order-{value}");
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public OrderBuilder Token(string value) => ChainClass(value.StartsWith("order-") ? value : $"order-{value}");
}