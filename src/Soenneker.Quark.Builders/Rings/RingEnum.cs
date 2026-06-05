using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the ring enum.
/// </summary>
[EnumValue<string>]
public sealed partial class RingEnum
{
    /// <summary>
    /// The default.
    /// </summary>
    public static readonly RingEnum Default = new("ring");
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly RingEnum None = new("ring-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly RingEnum Is1 = new("ring-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly RingEnum Is2 = new("ring-2");
    /// <summary>
    /// The is4.
    /// </summary>
    public static readonly RingEnum Is4 = new("ring-4");
    /// <summary>
    /// The is8.
    /// </summary>
    public static readonly RingEnum Is8 = new("ring-8");
    /// <summary>
    /// The inset.
    /// </summary>
    public static readonly RingEnum Inset = new("ring-inset");
}
