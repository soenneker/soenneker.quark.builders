using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the background size enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BackgroundSizeEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly BackgroundSizeEnum Auto = new("bg-auto");
    /// <summary>
    /// The cover.
    /// </summary>
    public static readonly BackgroundSizeEnum Cover = new("bg-cover");
    /// <summary>
    /// The contain.
    /// </summary>
    public static readonly BackgroundSizeEnum Contain = new("bg-contain");
}
