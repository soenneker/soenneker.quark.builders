namespace Soenneker.Quark;

/// <summary>
/// Tailwind whitespace utility entry points.
/// </summary>
[TailwindModifiers(typeof(WhitespaceBuilder))]
public static partial class Whitespace
{
    /// <summary>
    /// Fluent step for `Normal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder Normal => new(WhitespaceEnum.NormalValue);
    /// <summary>
    /// Fluent step for `Nowrap` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder Nowrap => new(WhitespaceEnum.NowrapValue);
    /// <summary>
    /// Fluent step for `Pre` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder Pre => new(WhitespaceEnum.PreValue);
    /// <summary>
    /// Fluent step for `Pre Line` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder PreLine => new(WhitespaceEnum.PreLineValue);
    /// <summary>
    /// Fluent step for `Pre Wrap` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder PreWrap => new(WhitespaceEnum.PreWrapValue);
    /// <summary>
    /// Fluent step for `Break Spaces` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder BreakSpaces => new(WhitespaceEnum.BreakSpacesValue);
}
