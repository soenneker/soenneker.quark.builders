namespace Soenneker.Quark;

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

    public OrderBuilder First => ChainClass(OrderEnum.First.Value);
    public OrderBuilder Last => ChainClass(OrderEnum.Last.Value);
    public OrderBuilder None => ChainClass(OrderEnum.None.Value);
    public OrderBuilder Is1 => ChainClass(OrderEnum.Is1.Value);
    public OrderBuilder Is12 => ChainClass(OrderEnum.Is12.Value);
    public OrderBuilder At(int value) => ChainClass($"order-{value}");
    public OrderBuilder Token(string value) => ChainClass(value.StartsWith("order-") ? value : $"order-{value}");
}