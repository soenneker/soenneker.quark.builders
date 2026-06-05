using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the aspect ratio enum.
/// </summary>
[EnumValue<string>]
public sealed partial class AspectRatioEnum
{
    /// <summary>
    /// The r1 x1.
    /// </summary>
    public static readonly AspectRatioEnum R1X1 = new("aspect-square");
    /// <summary>
    /// The r4 x3.
    /// </summary>
    public static readonly AspectRatioEnum R4X3 = new("aspect-[4/3]");
    /// <summary>
    /// The r16 x9.
    /// </summary>
    public static readonly AspectRatioEnum R16X9 = new("aspect-video");
    /// <summary>
    /// The r21 x9.
    /// </summary>
    public static readonly AspectRatioEnum R21X9 = new("aspect-[21/9]");
}
