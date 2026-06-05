using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the forced color adjust enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ForcedColorAdjustEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly ForcedColorAdjustEnum Auto = new("forced-color-adjust-auto");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ForcedColorAdjustEnum None = new("forced-color-adjust-none");
}
