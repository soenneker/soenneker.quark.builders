namespace Soenneker.Quark;

public static class Items
{
    public static ItemsBuilder Start => new(ItemsEnum.Start);
    public static ItemsBuilder End => new(ItemsEnum.End);
    public static ItemsBuilder Center => new(ItemsEnum.Center);
    public static ItemsBuilder Baseline => new(ItemsEnum.Baseline);
    public static ItemsBuilder Stretch => new(ItemsEnum.Stretch);
    public static ItemsBuilder Token(string value) => new("items-" + value);
}
