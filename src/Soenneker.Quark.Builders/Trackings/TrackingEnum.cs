using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the tracking enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TrackingEnum
{
    /// <summary>
    /// The tighter.
    /// </summary>
    public static readonly TrackingEnum Tighter = new("tracking-tighter");
    /// <summary>
    /// The tight.
    /// </summary>
    public static readonly TrackingEnum Tight = new("tracking-tight");
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly TrackingEnum Normal = new("tracking-normal");
    /// <summary>
    /// The wide.
    /// </summary>
    public static readonly TrackingEnum Wide = new("tracking-wide");
    /// <summary>
    /// The wider.
    /// </summary>
    public static readonly TrackingEnum Wider = new("tracking-wider");
    /// <summary>
    /// The widest.
    /// </summary>
    public static readonly TrackingEnum Widest = new("tracking-widest");
}
