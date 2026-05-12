namespace Soenneker.Quark;

/// <summary>
/// Scale utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(ScaleBuilder))]
public static partial class Scale
{
    public static ScaleBuilder Scale50 => new(ScaleEnum.Scale50);
    public static ScaleBuilder Scale75 => new(ScaleEnum.Scale75);
    public static ScaleBuilder Scale90 => new(ScaleEnum.Scale90);
    public static ScaleBuilder Scale95 => new(ScaleEnum.Scale95);
    public static ScaleBuilder Scale100 => new(ScaleEnum.Scale100);
    public static ScaleBuilder Scale105 => new(ScaleEnum.Scale105);
    public static ScaleBuilder Scale110 => new(ScaleEnum.Scale110);
    public static ScaleBuilder Scale125 => new(ScaleEnum.Scale125);
    public static ScaleBuilder Scale150 => new(ScaleEnum.Scale150);

    /// <summary>
    /// Create from a ScaleEnum value.
    /// </summary>
    public static ScaleBuilder From(ScaleEnum scaleType) => new(scaleType);
}
