using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the accent color enum.
/// </summary>
[EnumValue<string>]
public sealed partial class AccentColorEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly AccentColorEnum Auto = new("accent-auto");
    /// <summary>
    /// The primary.
    /// </summary>
    public static readonly AccentColorEnum Primary = new("accent-primary");
    /// <summary>
    /// The transparent.
    /// </summary>
    public static readonly AccentColorEnum Transparent = new("accent-transparent");
    /// <summary>
    /// The current.
    /// </summary>
    public static readonly AccentColorEnum Current = new("accent-current");
}
