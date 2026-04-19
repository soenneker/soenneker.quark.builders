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
}
