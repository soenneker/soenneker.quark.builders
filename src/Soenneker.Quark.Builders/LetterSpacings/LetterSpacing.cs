namespace Soenneker.Quark;

public static class LetterSpacing
{
    public static LetterSpacingBuilder Tighter => new("tighter");
    public static LetterSpacingBuilder Tight => new("tight");
    public static LetterSpacingBuilder Normal => new("normal");
    public static LetterSpacingBuilder Wide => new("wide");
    public static LetterSpacingBuilder Wider => new("wider");
    public static LetterSpacingBuilder Widest => new("widest");
    public static LetterSpacingBuilder Token(string value) => new(value);
}
