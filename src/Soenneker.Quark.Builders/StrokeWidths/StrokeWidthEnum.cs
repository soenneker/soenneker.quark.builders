using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the stroke width enum.
/// </summary>
[EnumValue<string>]
public sealed partial class StrokeWidthEnum
{
    /// <summary>
    /// The is0.
    /// </summary>
    public static readonly StrokeWidthEnum Is0 = new("stroke-0");
    /// <summary>
    /// The is1.
    /// </summary>
    public static readonly StrokeWidthEnum Is1 = new("stroke-1");
    /// <summary>
    /// The is2.
    /// </summary>
    public static readonly StrokeWidthEnum Is2 = new("stroke-2");
}
