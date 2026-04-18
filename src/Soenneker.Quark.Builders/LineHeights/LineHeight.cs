namespace Soenneker.Quark;

public static class LineHeight
{
    public static LineHeightBuilder Is1 => new("1");
    public static LineHeightBuilder None => new("none");
    public static LineHeightBuilder Tight => new("tight");
    public static LineHeightBuilder Snug => new("snug");
    public static LineHeightBuilder Normal => new("normal");
    public static LineHeightBuilder Relaxed => new("relaxed");
    public static LineHeightBuilder Loose => new("loose");
    public static LineHeightBuilder Large => new("relaxed");
    public static LineHeightBuilder Token(string value) => new(value);
}
