using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Soenneker.Utils.PooledStringBuilders;

namespace Soenneker.Quark;

/// <summary>
/// Background-blend-mode builder. Tailwind: bg-blend-normal, bg-blend-multiply, etc.
/// </summary>
[TailwindPrefix("bg-blend-", Responsive = true)]
public sealed class BackgroundBlendModeBuilder : CssBuilderBase<BackgroundBlendModeBuilder>
{
    private RuleList<BackgroundBlendModeRule> _rules;

    internal BackgroundBlendModeBuilder()
    {
    }

    internal BackgroundBlendModeBuilder(string value, BreakpointType? breakpoint = null)
    {
        _rules.Add(new BackgroundBlendModeRule(value, breakpoint));
    }

    internal BackgroundBlendModeBuilder(List<BackgroundBlendModeRule> rules)
    {
        if (rules is { Count: > 0 })
            _rules.AddRange(rules);
    }

    /// <summary>
    /// Fluent step for `Normal` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Normal => Chain("bg-blend-normal");
    /// <summary>
    /// Fluent step for `Multiply` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Multiply => Chain("bg-blend-multiply");
    /// <summary>
    /// Viewport-relative size (e.g. `w-screen`, `min-h-screen`) tied to the viewport width/height.
    /// </summary>
    public BackgroundBlendModeBuilder Screen => Chain("bg-blend-screen");
    /// <summary>
    /// Fluent step for `Overlay` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Overlay => Chain("bg-blend-overlay");
    /// <summary>
    /// Fluent step for `Darken` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Darken => Chain("bg-blend-darken");
    /// <summary>
    /// Fluent step for `Lighten` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Lighten => Chain("bg-blend-lighten");
    /// <summary>
    /// Fluent step for `Color Dodge` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder ColorDodge => Chain("bg-blend-color-dodge");
    /// <summary>
    /// Fluent step for `Color Burn` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder ColorBurn => Chain("bg-blend-color-burn");
    /// <summary>
    /// Fluent step for `Hard Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder HardLight => Chain("bg-blend-hard-light");
    /// <summary>
    /// Fluent step for `Soft Light` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder SoftLight => Chain("bg-blend-soft-light");
    /// <summary>
    /// Fluent step for `Difference` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Difference => Chain("bg-blend-difference");
    /// <summary>
    /// Fluent step for `Exclusion` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Exclusion => Chain("bg-blend-exclusion");
    /// <summary>
    /// Fluent step for `Hue` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Hue => Chain("bg-blend-hue");
    /// <summary>
    /// Fluent step for `Saturation` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Saturation => Chain("bg-blend-saturation");
    /// <summary>
    /// Fluent step for `Color` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Color => Chain("bg-blend-color");
    /// <summary>
    /// Fluent step for `Luminosity` in this Tailwind/shadcn-aligned builder. See the corresponding `-*` utility in the Tailwind docs for exact CSS.
    /// </summary>
    public BackgroundBlendModeBuilder Luminosity => Chain("bg-blend-luminosity");


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private BackgroundBlendModeBuilder Chain(string value)
    {
        _rules.Add(new BackgroundBlendModeRule(value, null, ConsumePendingModifierChain()));
        return this;
    }



    public override string ToClass()
    {
        if (_rules.Count == 0)
            return string.Empty;
        if (_rules.Count == 1)
        {
            BackgroundBlendModeRule rule = _rules[0];
            return ClassWriter.Render(rule.Value, BreakpointUtil.GetBreakpointToken(rule.Breakpoint), rule.ModifierChain);
        }

        var writer = new ClassWriter();
        try
        {
            for (var i = 0; i < _rules.Count; i++)
            {
                BackgroundBlendModeRule rule = _rules[i];
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
