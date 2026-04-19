namespace Soenneker.Quark;

public static class LineHeight
{
    public static LineHeightBuilder Is1 => new("leading-1");
    public static LineHeightBuilder None => new("leading-none");
    public static LineHeightBuilder Tight => new("leading-tight");
    public static LineHeightBuilder Snug => new("leading-snug");
    public static LineHeightBuilder Normal => new("leading-normal");
    public static LineHeightBuilder Relaxed => new("leading-relaxed");
    public static LineHeightBuilder Loose => new("leading-loose");
    public static LineHeightBuilder Large => new("leading-relaxed");
    public static LineHeightBuilder Token(string value) => new($"leading-{value}");
}
