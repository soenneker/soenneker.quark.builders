namespace Soenneker.Quark;

[TailwindModifiers(typeof(OrderBuilder))]
public static partial class Order
{
    public static OrderBuilder First => new(OrderEnum.First);
    public static OrderBuilder Last => new(OrderEnum.Last);
    public static OrderBuilder None => new(OrderEnum.None);
    public static OrderBuilder Is1 => new(OrderEnum.Is1);
    public static OrderBuilder Is12 => new(OrderEnum.Is12);
    public static OrderBuilder At(int value) => new($"order-{value}");
    public static OrderBuilder Token(string value) => new(value.StartsWith("order-") ? value : $"order-{value}");
}
