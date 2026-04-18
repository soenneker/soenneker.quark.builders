namespace Soenneker.Quark;

public static class Content
{
    public static ContentBuilder Normal => new(ContentEnum.Normal);
    public static ContentBuilder Center => new(ContentEnum.Center);
    public static ContentBuilder Start => new(ContentEnum.Start);
    public static ContentBuilder End => new(ContentEnum.End);
    public static ContentBuilder Between => new(ContentEnum.Between);
    public static ContentBuilder Around => new(ContentEnum.Around);
    public static ContentBuilder Evenly => new(ContentEnum.Evenly);
    public static ContentBuilder Stretch => new(ContentEnum.Stretch);
    public static ContentBuilder Baseline => new(ContentEnum.Baseline);
    public static ContentBuilder Token(string value) => new(value);
}
