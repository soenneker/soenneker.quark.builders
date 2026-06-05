using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the font variant numeric enum.
/// </summary>
[EnumValue<string>]
public sealed partial class FontVariantNumericEnum
{
    /// <summary>
    /// The normal nums.
    /// </summary>
    public static readonly FontVariantNumericEnum NormalNums = new("normal-nums");
    /// <summary>
    /// The ordinal.
    /// </summary>
    public static readonly FontVariantNumericEnum Ordinal = new("ordinal");
    /// <summary>
    /// The slashed zero.
    /// </summary>
    public static readonly FontVariantNumericEnum SlashedZero = new("slashed-zero");
    /// <summary>
    /// The lining nums.
    /// </summary>
    public static readonly FontVariantNumericEnum LiningNums = new("lining-nums");
    /// <summary>
    /// The oldstyle nums.
    /// </summary>
    public static readonly FontVariantNumericEnum OldstyleNums = new("oldstyle-nums");
    /// <summary>
    /// The proportional nums.
    /// </summary>
    public static readonly FontVariantNumericEnum ProportionalNums = new("proportional-nums");
    /// <summary>
    /// The tabular nums.
    /// </summary>
    public static readonly FontVariantNumericEnum TabularNums = new("tabular-nums");
    /// <summary>
    /// The diagonal fractions.
    /// </summary>
    public static readonly FontVariantNumericEnum DiagonalFractions = new("diagonal-fractions");
    /// <summary>
    /// The stacked fractions.
    /// </summary>
    public static readonly FontVariantNumericEnum StackedFractions = new("stacked-fractions");
}
