using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class LeadingEnum
{
    public static readonly LeadingEnum None = new("none");
    public static readonly LeadingEnum Tight = new("tight");
    public static readonly LeadingEnum Snug = new("snug");
    public static readonly LeadingEnum Normal = new("normal");
    public static readonly LeadingEnum Relaxed = new("relaxed");
    public static readonly LeadingEnum Loose = new("loose");
}
