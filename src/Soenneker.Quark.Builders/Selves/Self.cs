namespace Soenneker.Quark;

public static class Self
{
    public static SelfBuilder Auto => new(SelfEnum.Auto);
    public static SelfBuilder Start => new(SelfEnum.Start);
    public static SelfBuilder End => new(SelfEnum.End);
    public static SelfBuilder Center => new(SelfEnum.Center);
    public static SelfBuilder Stretch => new(SelfEnum.Stretch);
    public static SelfBuilder Baseline => new(SelfEnum.Baseline);
    public static SelfBuilder Token(string value) => new("self-" + value);
}
