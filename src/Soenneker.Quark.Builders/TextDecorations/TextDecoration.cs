namespace Soenneker.Quark;

public static class TextDecoration
{
    public static TextDecorationBuilder None => new("none");
    public static TextDecorationBuilder Underline => new("underline");
    public static TextDecorationBuilder LineThrough => new("line-through");
    public static TextDecorationBuilder Overline => new("overline");
    public static TextDecorationBuilder Token(string value) => new(value);
}
