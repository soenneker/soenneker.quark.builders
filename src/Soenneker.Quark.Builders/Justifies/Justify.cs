namespace Soenneker.Quark;

public static class Justify
{
    public static JustifyBuilder Normal => new(JustifyEnum.Normal);
    public static JustifyBuilder Start => new(JustifyEnum.Start);
    public static JustifyBuilder End => new(JustifyEnum.End);
    public static JustifyBuilder Center => new(JustifyEnum.Center);
    public static JustifyBuilder Between => new(JustifyEnum.Between);
    public static JustifyBuilder Around => new(JustifyEnum.Around);
    public static JustifyBuilder Evenly => new(JustifyEnum.Evenly);
    public static JustifyBuilder Stretch => new(JustifyEnum.Stretch);
    public static JustifyBuilder Token(string value) => new(value);
}
