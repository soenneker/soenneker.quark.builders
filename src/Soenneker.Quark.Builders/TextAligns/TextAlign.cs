namespace Soenneker.Quark;

[TailwindModifiers(typeof(TextAlignBuilder))]
public static partial class TextAlign
{
    public static TextAlignBuilder Start => new(TextAlignmentEnum.Start);
    public static TextAlignBuilder Left => new("text-left");
    public static TextAlignBuilder Center => new(TextAlignmentEnum.Center);
    public static TextAlignBuilder Right => new("text-right");
    public static TextAlignBuilder End => new(TextAlignmentEnum.End);
    public static TextAlignBuilder Token(string value) => new("text-" + value);
}
