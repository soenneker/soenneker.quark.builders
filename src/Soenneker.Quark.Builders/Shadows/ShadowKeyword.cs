using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class ShadowKeyword
{
    public static readonly ShadowKeyword None = new("shadow-none");
    public static readonly ShadowKeyword Xs = new("shadow-xs");
    public static readonly ShadowKeyword Sm = new("shadow-sm");
    public static readonly ShadowKeyword Default = new("shadow");
    public static readonly ShadowKeyword Md = new("shadow-md");
    public static readonly ShadowKeyword Lg = new("shadow-lg");
    public static readonly ShadowKeyword Xl = new("shadow-xl");
    public static readonly ShadowKeyword TwoXl = new("shadow-2xl");
    public static readonly ShadowKeyword Inner = new("shadow-inner");
}
