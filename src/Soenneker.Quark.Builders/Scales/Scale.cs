namespace Soenneker.Quark;

/// <summary>
/// Scale utility with fluent API and Tailwind/shadcn-aligned fluent API.
/// </summary>
public static class Scale
{
    // Legacy heading scale tokens still used by the suite demo.
    public static string Is1 => "scale-1";
    public static string Is2 => "scale-2";
    public static string Is3 => "scale-3";
    public static string Is4 => "scale-4";
    public static string Is5 => "scale-5";
    public static string Is6 => "scale-6";

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
