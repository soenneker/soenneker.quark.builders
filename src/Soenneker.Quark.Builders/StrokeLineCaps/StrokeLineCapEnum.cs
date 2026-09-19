using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the stroke line cap enum.
/// </summary>
[EnumValue<string>]
public sealed partial class StrokeLineCapEnum
{
    /// <summary>
    /// The round.
    /// </summary>
    public static readonly StrokeLineCapEnum Round = new("[stroke-linecap:round]");
    /// <summary>
    /// The square.
    /// </summary>
    public static readonly StrokeLineCapEnum Square = new("[stroke-linecap:square]");
    /// <summary>
    /// The butt.
    /// </summary>
    public static readonly StrokeLineCapEnum Butt = new("[stroke-linecap:butt]");
}
