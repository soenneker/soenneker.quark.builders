using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class AspectRatioEnum
{
    public static readonly AspectRatioEnum R1X1 = new("aspect-square");
    public static readonly AspectRatioEnum R4X3 = new("aspect-[4/3]");
    public static readonly AspectRatioEnum R16X9 = new("aspect-video");
    public static readonly AspectRatioEnum R21X9 = new("aspect-[21/9]");
}
