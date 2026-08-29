namespace Soenneker.Quark;

/// <summary>
/// Represents the leading.
/// </summary>
[TailwindModifiers(typeof(LeadingBuilder))]
public static partial class Leading
{
    /// <summary>
    /// Gets or sets none.
    /// </summary>
    public static LeadingBuilder None => new(LeadingEnum.None);
    /// <summary>
    /// Gets or sets tight.
    /// </summary>
    public static LeadingBuilder Tight => new(LeadingEnum.Tight);
    /// <summary>
    /// Gets or sets snug.
    /// </summary>
    public static LeadingBuilder Snug => new(LeadingEnum.Snug);
    /// <summary>
    /// Gets or sets normal.
    /// </summary>
    public static LeadingBuilder Normal => new(LeadingEnum.Normal);
    /// <summary>
    /// Gets or sets relaxed.
    /// </summary>
    public static LeadingBuilder Relaxed => new(LeadingEnum.Relaxed);
    /// <summary>
    /// Gets or sets loose.
    /// </summary>
    public static LeadingBuilder Loose => new(LeadingEnum.Loose);
    /// <summary>
    /// Gets or sets is0.
    /// </summary>
    public static LeadingBuilder Is0 => new(LeadingEnum.Is0);
    /// <summary>
    /// Gets or sets is1.
    /// </summary>
    public static LeadingBuilder Is1 => new(LeadingEnum.Is1);
    /// <summary>
    /// Gets or sets is2.
    /// </summary>
    public static LeadingBuilder Is2 => new(LeadingEnum.Is2);
    /// <summary>
    /// Gets or sets is3.
    /// </summary>
    public static LeadingBuilder Is3 => new(LeadingEnum.Is3);
    /// <summary>
    /// Gets or sets is4.
    /// </summary>
    public static LeadingBuilder Is4 => new(LeadingEnum.Is4);
    /// <summary>
    /// Gets or sets is4 5.
    /// </summary>
    public static LeadingBuilder Is4_5 => new(LeadingEnum.Is4_5);
    /// <summary>
    /// Gets or sets is5.
    /// </summary>
    public static LeadingBuilder Is5 => new(LeadingEnum.Is5);
    /// <summary>
    /// Gets or sets is6.
    /// </summary>
    public static LeadingBuilder Is6 => new(LeadingEnum.Is6);
    /// <summary>
    /// Gets or sets is6 5.
    /// </summary>
    public static LeadingBuilder Is6_5 => new(LeadingEnum.Is6_5);
    /// <summary>
    /// Gets or sets is7.
    /// </summary>
    public static LeadingBuilder Is7 => new(LeadingEnum.Is7);
    /// <summary>
    /// Gets or sets is8.
    /// </summary>
    public static LeadingBuilder Is8 => new(LeadingEnum.Is8);
    /// <summary>
    /// Gets or sets is9.
    /// </summary>
    public static LeadingBuilder Is9 => new(LeadingEnum.Is9);
    /// <summary>
    /// Gets or sets is10.
    /// </summary>
    public static LeadingBuilder Is10 => new(LeadingEnum.Is10);
    /// <summary>
    /// Adds an arbitrary leading utility token to the class list.
    /// </summary>
    /// <param name="value">Arbitrary utility value to append without predefined validation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static LeadingBuilder Token(string value) => new("leading-" + value);
}
