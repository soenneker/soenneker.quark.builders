namespace Soenneker.Quark;

[TailwindModifiers(typeof(LeadingBuilder))]
public static partial class Leading
{
    public static LeadingBuilder None => new(LeadingEnum.None);
    public static LeadingBuilder Tight => new(LeadingEnum.Tight);
    public static LeadingBuilder Snug => new(LeadingEnum.Snug);
    public static LeadingBuilder Normal => new(LeadingEnum.Normal);
    public static LeadingBuilder Relaxed => new(LeadingEnum.Relaxed);
    public static LeadingBuilder Loose => new(LeadingEnum.Loose);
    public static LeadingBuilder Is0 => new(LeadingEnum.Is0);
    public static LeadingBuilder Is1 => new(LeadingEnum.Is1);
    public static LeadingBuilder Is2 => new(LeadingEnum.Is2);
    public static LeadingBuilder Is3 => new(LeadingEnum.Is3);
    public static LeadingBuilder Is4 => new(LeadingEnum.Is4);
    public static LeadingBuilder Is5 => new(LeadingEnum.Is5);
    public static LeadingBuilder Is6 => new(LeadingEnum.Is6);
    public static LeadingBuilder Is7 => new(LeadingEnum.Is7);
    public static LeadingBuilder Is8 => new(LeadingEnum.Is8);
    public static LeadingBuilder Is9 => new(LeadingEnum.Is9);
    public static LeadingBuilder Is10 => new(LeadingEnum.Is10);
    public static LeadingBuilder Token(string value) => new("leading-" + value);
}
