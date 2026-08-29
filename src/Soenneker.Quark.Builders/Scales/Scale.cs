namespace Soenneker.Quark;

/// <summary>
/// Scale utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
[TailwindModifiers(typeof(ScaleBuilder))]
public static partial class Scale
{
    /// <summary>
    /// Gets or sets scale50.
    /// </summary>
    public static ScaleBuilder Scale50 => new(ScaleEnum.Scale50);
    /// <summary>
    /// Gets or sets scale75.
    /// </summary>
    public static ScaleBuilder Scale75 => new(ScaleEnum.Scale75);
    /// <summary>
    /// Gets or sets scale90.
    /// </summary>
    public static ScaleBuilder Scale90 => new(ScaleEnum.Scale90);
    /// <summary>
    /// Gets or sets scale95.
    /// </summary>
    public static ScaleBuilder Scale95 => new(ScaleEnum.Scale95);
    /// <summary>
    /// Gets or sets scale100.
    /// </summary>
    public static ScaleBuilder Scale100 => new(ScaleEnum.Scale100);
    /// <summary>
    /// Gets or sets scale105.
    /// </summary>
    public static ScaleBuilder Scale105 => new(ScaleEnum.Scale105);
    /// <summary>
    /// Gets or sets scale110.
    /// </summary>
    public static ScaleBuilder Scale110 => new(ScaleEnum.Scale110);
    /// <summary>
    /// Gets or sets scale125.
    /// </summary>
    public static ScaleBuilder Scale125 => new(ScaleEnum.Scale125);
    /// <summary>
    /// Gets or sets scale150.
    /// </summary>
    public static ScaleBuilder Scale150 => new(ScaleEnum.Scale150);

    /// <summary>
    /// Create from a ScaleEnum value.
    /// </summary>
    /// <param name="scaleType">Scale axis or mode to target.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static ScaleBuilder From(ScaleEnum scaleType) => new(scaleType);
}
