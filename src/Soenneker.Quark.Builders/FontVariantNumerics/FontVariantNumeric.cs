namespace Soenneker.Quark;

/// <summary>
/// Tailwind font variant numeric utility entry points.
/// </summary>
public static class FontVariantNumeric
{
    /// <summary>
    /// Fluent step for `Normal Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder NormalNums => new(FontVariantNumericEnum.NormalNums);
    /// <summary>
    /// Fluent step for `Ordinal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder Ordinal => new(FontVariantNumericEnum.Ordinal);
    /// <summary>
    /// Fluent step for `Slashed Zero` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder SlashedZero => new(FontVariantNumericEnum.SlashedZero);
    /// <summary>
    /// Fluent step for `Lining Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder LiningNums => new(FontVariantNumericEnum.LiningNums);
    /// <summary>
    /// Fluent step for `Oldstyle Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder OldstyleNums => new(FontVariantNumericEnum.OldstyleNums);
    /// <summary>
    /// Fluent step for `Proportional Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder ProportionalNums => new(FontVariantNumericEnum.ProportionalNums);
    /// <summary>
    /// Fluent step for `Tabular Nums` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder TabularNums => new(FontVariantNumericEnum.TabularNums);
    /// <summary>
    /// Fluent step for `Diagonal Fractions` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder DiagonalFractions => new(FontVariantNumericEnum.DiagonalFractions);
    /// <summary>
    /// Fluent step for `Stacked Fractions` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FontVariantNumericBuilder StackedFractions => new(FontVariantNumericEnum.StackedFractions);
}
