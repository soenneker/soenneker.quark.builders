using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class LeadingEnum
{
    public static readonly LeadingEnum None = new("leading-none");
    public static readonly LeadingEnum Tight = new("leading-tight");
    public static readonly LeadingEnum Snug = new("leading-snug");
    public static readonly LeadingEnum Normal = new("leading-normal");
    public static readonly LeadingEnum Relaxed = new("leading-relaxed");
    public static readonly LeadingEnum Loose = new("leading-loose");
    public static readonly LeadingEnum Is0 = new("leading-0");
    public static readonly LeadingEnum Is1 = new("leading-1");
    public static readonly LeadingEnum Is2 = new("leading-2");
    public static readonly LeadingEnum Is3 = new("leading-3");
    public static readonly LeadingEnum Is4 = new("leading-4");
    public static readonly LeadingEnum Is4_5 = new("leading-4.5");
    public static readonly LeadingEnum Is5 = new("leading-5");
    public static readonly LeadingEnum Is6 = new("leading-6");
    public static readonly LeadingEnum Is6_5 = new("leading-6.5");
    public static readonly LeadingEnum Is7 = new("leading-7");
    public static readonly LeadingEnum Is8 = new("leading-8");
    public static readonly LeadingEnum Is9 = new("leading-9");
    public static readonly LeadingEnum Is10 = new("leading-10");
}
