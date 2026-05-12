namespace Soenneker.Quark;

/// <summary>
/// Static utility for scroll snap align. Tailwind: snap-start, snap-center, snap-end, snap-align-none.
/// </summary>
[TailwindModifiers(typeof(ScrollSnapAlignBuilder))]
public static partial class ScrollSnapAlign
{
    /// <summary>
    /// Fluent step for `Start` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ScrollSnapAlignBuilder Start => new(ScrollSnapAlignEnum.Start);
    /// <summary>
    /// Fluent step for `Center` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ScrollSnapAlignBuilder Center => new(ScrollSnapAlignEnum.Center);
    /// <summary>
    /// Fluent step for `End` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ScrollSnapAlignBuilder End => new(ScrollSnapAlignEnum.End);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static ScrollSnapAlignBuilder None => new(ScrollSnapAlignEnum.None);
}
