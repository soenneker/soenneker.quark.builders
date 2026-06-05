namespace Soenneker.Quark;

/// <summary>
/// Represents the order.
/// </summary>
[TailwindModifiers(typeof(OrderBuilder))]
public static partial class Order
{
    /// <summary>
    /// Gets or sets first.
    /// </summary>
    public static OrderBuilder First => new(OrderEnum.First);
    /// <summary>
    /// Gets or sets last.
    /// </summary>
    public static OrderBuilder Last => new(OrderEnum.Last);
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static OrderBuilder None => new(OrderEnum.None);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static OrderBuilder Is1 => new(OrderEnum.Is1);
    /// <summary>
    /// Gets or sets is12.
    /// </summary>
    public static OrderBuilder Is12 => new(OrderEnum.Is12);
    /// <summary>
    /// Executes the at operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static OrderBuilder At(int value) => new($"order-{value}");
    /// <summary>
    /// Executes the token operation.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the operation.</returns>
    public static OrderBuilder Token(string value) => new(value.StartsWith("order-") ? value : $"order-{value}");
}
