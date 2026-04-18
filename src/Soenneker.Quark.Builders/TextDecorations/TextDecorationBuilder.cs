namespace Soenneker.Quark;

public sealed class TextDecorationBuilder : CssBuilderBase
{
    private readonly string _value;

    internal TextDecorationBuilder(string value)
    {
        _value = value;
    }

    public TextDecorationBuilder None => new("none");
    public TextDecorationBuilder Underline => new("underline");
    public TextDecorationBuilder LineThrough => new("line-through");
    public TextDecorationBuilder Overline => new("overline");
    public TextDecorationBuilder Token(string value) => new(value);

    public override string ToClass() => _value switch
    {
        "none" => "no-underline",
        "underline" => "underline",
        "line-through" => "line-through",
        "overline" => "overline",
        _ => _value
    };

    public override string ToStyle() => _value switch
    {
        "none" => "text-decoration: none",
        "underline" => "text-decoration: underline",
        "line-through" => "text-decoration: line-through",
        "overline" => "text-decoration: overline",
        _ => string.Empty
    };

    public override string ToString() => ToClass();
}
