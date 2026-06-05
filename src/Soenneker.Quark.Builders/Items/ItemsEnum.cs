using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the items enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ItemsEnum
{
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly ItemsEnum Start = new("items-start");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly ItemsEnum End = new("items-end");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly ItemsEnum Center = new("items-center");
    /// <summary>
    /// The baseline.
    /// </summary>
    public static readonly ItemsEnum Baseline = new("items-baseline");
    /// <summary>
    /// The stretch.
    /// </summary>
    public static readonly ItemsEnum Stretch = new("items-stretch");
}
