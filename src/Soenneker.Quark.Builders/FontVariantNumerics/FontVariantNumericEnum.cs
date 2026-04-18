using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class FontVariantNumericEnum
{
    public static readonly FontVariantNumericEnum NormalNums = new("normal-nums");
    public static readonly FontVariantNumericEnum Ordinal = new("ordinal");
    public static readonly FontVariantNumericEnum SlashedZero = new("slashed-zero");
    public static readonly FontVariantNumericEnum LiningNums = new("lining-nums");
    public static readonly FontVariantNumericEnum OldstyleNums = new("oldstyle-nums");
    public static readonly FontVariantNumericEnum ProportionalNums = new("proportional-nums");
    public static readonly FontVariantNumericEnum TabularNums = new("tabular-nums");
    public static readonly FontVariantNumericEnum DiagonalFractions = new("diagonal-fractions");
    public static readonly FontVariantNumericEnum StackedFractions = new("stacked-fractions");
}
