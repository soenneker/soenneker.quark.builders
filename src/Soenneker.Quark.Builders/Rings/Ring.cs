namespace Soenneker.Quark;

/// <summary>
/// Tailwind ring utility.
/// </summary>
[TailwindModifiers(typeof(RingBuilder))]
public static partial class Ring
{
    /// <summary>
    /// Default theme radius: `rounded` with no suffix — in Tailwind’s default config typically `0.25rem` (maps to shadcn `--radius` usage when you align tokens).
    /// </summary>
    public static RingBuilder Default => new(RingEnum.Default);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static RingBuilder None => new(RingEnum.None);
    public static RingBuilder Is1 => new(RingEnum.Is1);
    public static RingBuilder Is2 => new(RingEnum.Is2);
    public static RingBuilder Is4 => new(RingEnum.Is4);
    public static RingBuilder Is8 => new(RingEnum.Is8);
    /// <summary>
    /// Fluent step for `Inset` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static RingBuilder Inset => new(RingEnum.Inset);
}
