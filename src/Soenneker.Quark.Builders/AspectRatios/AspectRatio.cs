
namespace Soenneker.Quark;

/// <summary>
/// Simplified aspect ratio utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(AspectRatioBuilder))]
public static partial class AspectRatio
{
    /// <summary>
    /// 1:1 aspect ratio (square).
    /// </summary>
    public static AspectRatioBuilder R1X1 => new(AspectRatioEnum.R1X1);

    /// <summary> 
    /// 4:3 aspect ratio.
    /// </summary>
    public static AspectRatioBuilder R4X3 => new(AspectRatioEnum.R4X3);

    /// <summary>
    /// 16:9 aspect ratio.
    /// </summary>
    public static AspectRatioBuilder R16X9 => new(AspectRatioEnum.R16X9);

    /// <summary>
    /// 21:9 aspect ratio.
    /// </summary>
    public static AspectRatioBuilder R21X9 => new(AspectRatioEnum.R21X9);
}
