namespace Soenneker.Quark;

[TailwindModifiers(typeof(ContentAlignBuilder))]
public static partial class ContentAlign
{
    public static ContentAlignBuilder Normal => new(ContentEnum.Normal);
    public static ContentAlignBuilder Center => new(ContentEnum.Center);
    public static ContentAlignBuilder Start => new(ContentEnum.Start);
    public static ContentAlignBuilder End => new(ContentEnum.End);
    public static ContentAlignBuilder Between => new(ContentEnum.Between);
    public static ContentAlignBuilder Around => new(ContentEnum.Around);
    public static ContentAlignBuilder Evenly => new(ContentEnum.Evenly);
    public static ContentAlignBuilder Stretch => new(ContentEnum.Stretch);
    public static ContentAlignBuilder Baseline => new(ContentEnum.Baseline);
    public static ContentAlignBuilder Token(string value) => new("content-" + value);
}
