namespace Soenneker.Quark;

/// <summary>
/// Static utility for stroke line join. Uses Tailwind arbitrary CSS properties.
/// </summary>
[TailwindModifiers(typeof(StrokeLineJoinBuilder))]
public static partial class StrokeLineJoin
{
    /// <summary>
    /// Fluent step for `Round` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static StrokeLineJoinBuilder Round => new(StrokeLineJoinEnum.Round);
    /// <summary>
    /// Fluent step for `Bevel` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static StrokeLineJoinBuilder Bevel => new(StrokeLineJoinEnum.Bevel);
    /// <summary>
    /// Fluent step for `Miter` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static StrokeLineJoinBuilder Miter => new(StrokeLineJoinEnum.Miter);
}
