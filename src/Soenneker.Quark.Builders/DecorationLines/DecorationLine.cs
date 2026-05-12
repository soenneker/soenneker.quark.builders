namespace Soenneker.Quark;

[TailwindModifiers(typeof(DecorationLineBuilder))]
public static partial class DecorationLine
{
    public static DecorationLineBuilder None => new(DecorationLineEnum.None);
    public static DecorationLineBuilder Underline => new(DecorationLineEnum.Underline);
    public static DecorationLineBuilder LineThrough => new(DecorationLineEnum.LineThrough);
    public static DecorationLineBuilder Overline => new(DecorationLineEnum.Overline);
    public static DecorationLineBuilder Token(string value) => new(value);
}
