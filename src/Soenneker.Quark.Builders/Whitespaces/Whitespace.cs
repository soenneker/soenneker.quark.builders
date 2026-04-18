namespace Soenneker.Quark;

/// <summary>
/// Tailwind whitespace utility entry points.
/// </summary>
public static class Whitespace
{
    /// <summary>
    /// Fluent step for `Normal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder Normal => new(WhitespaceEnum.Normal);
    /// <summary>
    /// Fluent step for `Nowrap` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder Nowrap => new(WhitespaceEnum.Nowrap);
    /// <summary>
    /// Fluent step for `Pre` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder Pre => new(WhitespaceEnum.Pre);
    /// <summary>
    /// Fluent step for `Pre Line` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder PreLine => new(WhitespaceEnum.PreLine);
    /// <summary>
    /// Fluent step for `Pre Wrap` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder PreWrap => new(WhitespaceEnum.PreWrap);
    /// <summary>
    /// Fluent step for `Break Spaces` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static WhitespaceBuilder BreakSpaces => new(WhitespaceEnum.BreakSpaces);
}
