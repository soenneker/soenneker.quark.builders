
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Mix-blend-mode builder. Tailwind: mix-blend-normal, mix-blend-multiply, etc.
/// </summary>
[TailwindPrefix("mix-blend-", Responsive = true)]
public sealed class MixBlendModeBuilder : CssBuilderBase<MixBlendModeBuilder>
{
    private RuleList<MixBlendModeRule> _rules;

    internal MixBlendModeBuilder()
    {
    }

    internal MixBlendModeBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new MixBlendModeRule(value, breakpoint));
    }

    internal MixBlendModeBuilder(MixBlendModeEnum value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new MixBlendModeRule(value.Value, breakpoint));
    }

    internal MixBlendModeBuilder(List<MixBlendModeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Normal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Normal => Chain(MixBlendModeEnum.NormalValue);
    /// <summary>
    /// Fluent step for `Multiply` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Multiply => Chain(MixBlendModeEnum.MultiplyValue);
    /// <summary>
    /// Viewport-relative size (e.g. `w-screen`, `min-h-screen`) tied to the viewport width/height.
    /// </summary>
    public MixBlendModeBuilder Screen => Chain(MixBlendModeEnum.ScreenValue);
    /// <summary>
    /// Fluent step for `Overlay` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Overlay => Chain(MixBlendModeEnum.OverlayValue);
    /// <summary>
    /// Fluent step for `Darken` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Darken => Chain(MixBlendModeEnum.DarkenValue);
    /// <summary>
    /// Fluent step for `Lighten` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Lighten => Chain(MixBlendModeEnum.LightenValue);
    /// <summary>
    /// Fluent step for `Color Dodge` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder ColorDodge => Chain(MixBlendModeEnum.ColorDodgeValue);
    /// <summary>
    /// Fluent step for `Color Burn` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder ColorBurn => Chain(MixBlendModeEnum.ColorBurnValue);
    /// <summary>
    /// Fluent step for `Hard Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder HardLight => Chain(MixBlendModeEnum.HardLightValue);
    /// <summary>
    /// Fluent step for `Soft Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder SoftLight => Chain(MixBlendModeEnum.SoftLightValue);
    /// <summary>
    /// Fluent step for `Difference` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Difference => Chain(MixBlendModeEnum.DifferenceValue);
    /// <summary>
    /// Fluent step for `Exclusion` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Exclusion => Chain(MixBlendModeEnum.ExclusionValue);
    /// <summary>
    /// Fluent step for `Hue` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Hue => Chain(MixBlendModeEnum.HueValue);
    /// <summary>
    /// Fluent step for `Saturation` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Saturation => Chain(MixBlendModeEnum.SaturationValue);
    /// <summary>
    /// Fluent step for `Color` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Color => Chain(MixBlendModeEnum.ColorValue);
    /// <summary>
    /// Fluent step for `Luminosity` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder Luminosity => Chain(MixBlendModeEnum.LuminosityValue);
    /// <summary>
    /// Fluent step for `Plus Darker` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder PlusDarker => Chain(MixBlendModeEnum.PlusDarkerValue);
    /// <summary>
    /// Fluent step for `Plus Lighter` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public MixBlendModeBuilder PlusLighter => Chain(MixBlendModeEnum.PlusLighterValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MixBlendModeBuilder Chain(string value)
    {
        _rules.Add(new MixBlendModeRule(value, null, ConsumePendingModifierChain()));
        return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private MixBlendModeBuilder Chain(MixBlendModeEnum value)
    {
        _rules.Add(new MixBlendModeRule(value.Value, null, ConsumePendingModifierChain()));
        return this;
    }

    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            MixBlendModeRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                MixBlendModeRule rule = _rules[i];
                writer.Add(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
            }
            return writer.ToString();
        }
        finally
        {
            writer.Dispose();
        }
    }

    /// <summary>
    /// Executes the to style operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToStyle() => string.Empty;

    /// <summary>
    /// Returns a string representation of the current instance.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public override string ToString() => ToClass();

}
