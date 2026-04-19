namespace Soenneker.Quark;

public static class JustifySelfAlign
{
    public static JustifySelfAlignBuilder Auto => new(JustifySelfAlignEnum.Auto);
    public static JustifySelfAlignBuilder Start => new(JustifySelfAlignEnum.Start);
    public static JustifySelfAlignBuilder End => new(JustifySelfAlignEnum.End);
    public static JustifySelfAlignBuilder Center => new(JustifySelfAlignEnum.Center);
    public static JustifySelfAlignBuilder Stretch => new(JustifySelfAlignEnum.Stretch);
    public static JustifySelfAlignBuilder Token(string value) => new(value);
}
