using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the stroke line join enum.
/// </summary>
[EnumValue<string>]
public sealed partial class StrokeLineJoinEnum
{
    /// <summary>
    /// The auto.
    /// </summary>
    public static readonly StrokeLineJoinEnum Auto = new("stroke-join-auto");
    /// <summary>
    /// The round.
    /// </summary>
    public static readonly StrokeLineJoinEnum Round = new("stroke-join-round");
    /// <summary>
    /// The bevel.
    /// </summary>
    public static readonly StrokeLineJoinEnum Bevel = new("stroke-join-bevel");
    /// <summary>
    /// The miter.
    /// </summary>
    public static readonly StrokeLineJoinEnum Miter = new("stroke-join-miter");
}
