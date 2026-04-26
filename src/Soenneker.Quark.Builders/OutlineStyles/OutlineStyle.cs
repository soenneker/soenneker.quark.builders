namespace Soenneker.Quark;

/// <summary>
/// Static utility for outline style. Tailwind: outline-none, outline, outline-dashed, outline-dotted, outline-double.
/// </summary>
public static class OutlineStyle
{
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static OutlineStyleBuilder None => new(OutlineStyleEnum.None);
    /// <summary>
    /// Hides the outline while preserving forced-colors accessibility behavior. Tailwind: outline-hidden.
    /// </summary>
    public static OutlineStyleBuilder Hidden => new(OutlineStyleEnum.Hidden);
    /// <summary>
    /// Fluent step for `Solid` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OutlineStyleBuilder Solid => new(OutlineStyleEnum.Solid);
    /// <summary>
    /// Fluent step for `Dashed` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OutlineStyleBuilder Dashed => new(OutlineStyleEnum.Dashed);
    /// <summary>
    /// Fluent step for `Dotted` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OutlineStyleBuilder Dotted => new(OutlineStyleEnum.Dotted);
    /// <summary>
    /// Fluent step for `Double` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static OutlineStyleBuilder Double => new(OutlineStyleEnum.Double);
}
