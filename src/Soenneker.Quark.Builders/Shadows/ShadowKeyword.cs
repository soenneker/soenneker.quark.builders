using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the shadow keyword.
/// </summary>
[EnumValue<string>]
public sealed partial class ShadowKeyword
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ShadowKeyword None = new("shadow-none");
    /// <summary>
    /// The xs.
    /// </summary>
    public static readonly ShadowKeyword Xs = new("shadow-xs");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly ShadowKeyword Sm = new("shadow-sm");
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly ShadowKeyword Default = new("shadow");
    /// <summary>
    /// The md.
    /// </summary>
    public static readonly ShadowKeyword Md = new("shadow-md");
    /// <summary>
    /// The lg.
    /// </summary>
    public static readonly ShadowKeyword Lg = new("shadow-lg");
    /// <summary>
    /// The xl.
    /// </summary>
    public static readonly ShadowKeyword Xl = new("shadow-xl");
    /// <summary>
    /// The two xl.
    /// </summary>
    public static readonly ShadowKeyword TwoXl = new("shadow-2xl");
    /// <summary>
    /// The inner.
    /// </summary>
    public static readonly ShadowKeyword Inner = new("shadow-inner");
}
