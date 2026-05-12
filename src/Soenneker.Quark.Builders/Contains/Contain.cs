namespace Soenneker.Quark;

/// <summary>
/// Static utility for contain. Tailwind: contain-*.
/// </summary>
[TailwindModifiers(typeof(ContainBuilder))]
public static partial class Contain
{
    /// <summary>
    /// Disables the effect (`none` token) or sets size to zero, depending on the utility.
    /// </summary>
    public static ContainBuilder None => new(ContainEnum.None);
    /// <summary>
    /// Fluent step for `Size` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ContainBuilder Size => new(ContainEnum.Size);
    /// <summary>
    /// Fluent step for `Layout` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ContainBuilder Layout => new(ContainEnum.Layout);
    /// <summary>
    /// Fluent step for `Style` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ContainBuilder Style => new(ContainEnum.Style);
    /// <summary>
    /// Fluent step for `Paint` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ContainBuilder Paint => new(ContainEnum.Paint);
    /// <summary>
    /// Fluent step for `Strict` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ContainBuilder Strict => new(ContainEnum.Strict);
    /// <summary>
    /// Fluent step for `Content` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static ContainBuilder Content => new(ContainEnum.Content);
}
