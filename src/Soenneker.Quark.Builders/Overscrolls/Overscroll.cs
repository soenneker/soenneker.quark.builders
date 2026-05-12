namespace Soenneker.Quark;

/// <summary>
/// Tailwind overscroll-behavior utility entry points.
/// </summary>
[TailwindModifiers(typeof(OverscrollBuilder))]
public static partial class Overscroll
{
    /// <summary>
    /// `auto` — browser-default sizing/behavior for the underlying utility.
    /// </summary>
    public static OverscrollBuilder Auto => new(OverscrollEnum.Auto);
    /// <summary>
    /// Fluent step for `Contain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder Contain => new(OverscrollEnum.Contain);
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static OverscrollBuilder None => new(OverscrollEnum.None);

    /// <summary>
    /// Fluent step for `XAuto` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder XAuto => new(OverscrollEnum.XAuto);
    /// <summary>
    /// Fluent step for `XContain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder XContain => new(OverscrollEnum.XContain);
    /// <summary>
    /// Fluent step for `XNone` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder XNone => new(OverscrollEnum.XNone);

    /// <summary>
    /// Fluent step for `YAuto` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder YAuto => new(OverscrollEnum.YAuto);
    /// <summary>
    /// Fluent step for `YContain` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder YContain => new(OverscrollEnum.YContain);
    /// <summary>
    /// Fluent step for `YNone` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OverscrollBuilder YNone => new(OverscrollEnum.YNone);
}
