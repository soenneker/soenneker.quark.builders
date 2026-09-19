namespace Soenneker.Quark;

/// <summary>
/// Static utility for fill-rule (SVG). Uses Tailwind arbitrary CSS properties.
/// </summary>
[TailwindModifiers(typeof(FillRuleBuilder))]
public static partial class SvgFillRule
{
    /// <summary>
    /// Fluent step for `Evenodd` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FillRuleBuilder Evenodd => new(FillRuleEnum.Evenodd);
    /// <summary>
    /// Fluent step for `Nonzero` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public static FillRuleBuilder Nonzero => new(FillRuleEnum.Nonzero);
}
