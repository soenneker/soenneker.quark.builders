namespace Soenneker.Quark;

public static class TextAlign
{
    public static TextAlignBuilder Start => new(TextAlignmentEnum.Start);
    public static TextAlignBuilder Center => new(TextAlignmentEnum.Center);
    public static TextAlignBuilder End => new(TextAlignmentEnum.End);
    public static TextAlignBuilder Token(string value) => new(value);
}
