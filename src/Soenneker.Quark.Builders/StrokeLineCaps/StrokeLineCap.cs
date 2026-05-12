namespace Soenneker.Quark;

/// <summary>
/// Static utility for stroke line cap. Tailwind: stroke-cap-*.
/// </summary>
[TailwindModifiers(typeof(StrokeLineCapBuilder))]
public static partial class StrokeLineCap
{
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static StrokeLineCapBuilder Auto => new(StrokeLineCapEnum.Auto);
    /// <summary>
    /// Fluent step for `Round` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static StrokeLineCapBuilder Round => new(StrokeLineCapEnum.Round);
    /// <summary>
    /// Fluent step for `Square` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static StrokeLineCapBuilder Square => new(StrokeLineCapEnum.Square);
    /// <summary>
    /// Fluent step for `Butt` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static StrokeLineCapBuilder Butt => new(StrokeLineCapEnum.Butt);
}
