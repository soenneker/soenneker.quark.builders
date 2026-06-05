using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the leading enum.
/// </summary>
[EnumValue<string>]
public sealed partial class LeadingEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly LeadingEnum None = new("leading-none");
    /// <summary>
    /// The tight.
    /// </summary>
    public static readonly LeadingEnum Tight = new("leading-tight");
    /// <summary>
    /// The snug.
    /// </summary>
    public static readonly LeadingEnum Snug = new("leading-snug");
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly LeadingEnum Normal = new("leading-normal");
    /// <summary>
    /// The relaxed.
    /// </summary>
    public static readonly LeadingEnum Relaxed = new("leading-relaxed");
    /// <summary>
    /// The loose.
    /// </summary>
    public static readonly LeadingEnum Loose = new("leading-loose");
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly LeadingEnum Is0 = new("leading-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly LeadingEnum Is1 = new("leading-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly LeadingEnum Is2 = new("leading-2");
    /// <summary>
    /// The is3.
    /// </summary>
    public static readonly LeadingEnum Is3 = new("leading-3");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly LeadingEnum Is4 = new("leading-4");
    /// <summary>
    /// The is4 5.
    /// </summary>
    public static readonly LeadingEnum Is4_5 = new("leading-4.5");
    /// <summary>
    /// The is5.
    /// </summary>
    public static readonly LeadingEnum Is5 = new("leading-5");
    /// <summary>
    /// The is6.
    /// </summary>
    public static readonly LeadingEnum Is6 = new("leading-6");
    /// <summary>
    /// The is6 5.
    /// </summary>
    public static readonly LeadingEnum Is6_5 = new("leading-6.5");
    /// <summary>
    /// The is7.
    /// </summary>
    public static readonly LeadingEnum Is7 = new("leading-7");
    /// <summary>
    /// The is8.
    /// </summary>
    public static readonly LeadingEnum Is8 = new("leading-8");
    /// <summary>
    /// The is9.
    /// </summary>
    public static readonly LeadingEnum Is9 = new("leading-9");
    /// <summary>
    /// The is10.
    /// </summary>
    public static readonly LeadingEnum Is10 = new("leading-10");
}
