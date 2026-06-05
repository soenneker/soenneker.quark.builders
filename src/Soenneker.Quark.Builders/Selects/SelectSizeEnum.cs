using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the select size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class SelectSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly SelectSizeEnum Default = new("default");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly SelectSizeEnum Sm = new("sm");
}
