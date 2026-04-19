namespace Soenneker.Quark;

public static class Leading
{
    public static LeadingBuilder None => new(LeadingEnum.None);
    public static LeadingBuilder Tight => new(LeadingEnum.Tight);
    public static LeadingBuilder Snug => new(LeadingEnum.Snug);
    public static LeadingBuilder Normal => new(LeadingEnum.Normal);
    public static LeadingBuilder Relaxed => new(LeadingEnum.Relaxed);
    public static LeadingBuilder Loose => new(LeadingEnum.Loose);
    public static LeadingBuilder Token(string value) => new("leading-" + value);
}
