using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the switch size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class SwitchSizeEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly SwitchSizeEnum Default = new("default");
    /// <summary>
    /// The sm.
    /// </summary>
    public static readonly SwitchSizeEnum Sm = new("sm");
}
