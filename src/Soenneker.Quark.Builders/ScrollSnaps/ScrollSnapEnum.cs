using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the scroll snap enum.
/// </summary>
[EnumValue<string>]
public sealed partial class ScrollSnapEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly ScrollSnapEnum None = new("snap-none");
    /// <summary>
    /// The x.
    /// </summary>
    public static readonly ScrollSnapEnum X = new("snap-x");
    /// <summary>
    /// The y.
    /// </summary>
    public static readonly ScrollSnapEnum Y = new("snap-y");
    /// <summary>
    /// The both.
    /// </summary>
    public static readonly ScrollSnapEnum Both = new("snap-both");
    /// <summary>
    /// The mandatory.
    /// </summary>
    public static readonly ScrollSnapEnum Mandatory = new("snap-mandatory");
    /// <summary>
    /// The proximity.
    /// </summary>
    public static readonly ScrollSnapEnum Proximity = new("snap-proximity");
}
