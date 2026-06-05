using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the background image enum.
/// </summary>
[EnumValue<string>]
public sealed partial class BackgroundImageEnum
{
    /// <summary>
    /// The none.
    /// </summary>
    public static readonly BackgroundImageEnum None = new("bg-none");
    /// <summary>
    /// The linear to t.
    /// </summary>
    public static readonly BackgroundImageEnum LinearToT = new("bg-linear-to-t");
    /// <summary>
    /// The linear to r.
    /// </summary>
    public static readonly BackgroundImageEnum LinearToR = new("bg-linear-to-r");
    /// <summary>
    /// The linear to b.
    /// </summary>
    public static readonly BackgroundImageEnum LinearToB = new("bg-linear-to-b");
    /// <summary>
    /// The linear to l.
    /// </summary>
    public static readonly BackgroundImageEnum LinearToL = new("bg-linear-to-l");
    /// <summary>
    /// The radial.
    /// </summary>
    public static readonly BackgroundImageEnum Radial = new("bg-radial");
    /// <summary>
    /// The conic.
    /// </summary>
    public static readonly BackgroundImageEnum Conic = new("bg-conic");
}
