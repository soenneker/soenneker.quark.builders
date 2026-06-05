using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the hyphen enum.
/// </summary>
[EnumValue<string>]
public sealed partial class HyphenEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly HyphenEnum None = new("hyphens-none");
    /// <summary>
    /// The manual.
    /// </summary>
    public static readonly HyphenEnum Manual = new("hyphens-manual");
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly HyphenEnum Auto = new("hyphens-auto");
}
